using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Capgemini.SimplifiedYouTube.Common.Protos.Videos;
using Capgemini.SimplifiedYouTube.Facades.IVideos;
using Grpc.Net.Client;
using Kaddis.Framework.Utilities.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.SimplifiedYouTube.APIs.Videos.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowOrigin")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private IVideosFacade _videosFacade;

        public VideosController(IVideosFacade videosFacade)
        {
            _videosFacade = videosFacade;
        }

        // GET: api/videos
        [HttpGet]
        public WebHttpResponse<List<Video>> Index()
        {
            WebHttpResponse<List<Video>> response = new WebHttpResponse<List<Video>>();

            try
            {
                var data = _videosFacade.GetAll();
                response.Data.AddRange(data);
                response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.OK;
            }
            catch (Exception ex)
            {
                response.Data = null;
                response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.InternalServerError;
                response.Messages = ex.Message;
            }

            return response;
        }

        [HttpPost, DisableRequestSizeLimit]
        public WebHttpResponse<bool> Upload()
        {
            WebHttpResponse<bool> response = new WebHttpResponse<bool>();

            try
            {
                var file = Request.Form.Files[0];
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);

                if (file.Length > 0)
                {
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);

                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }

                    response.Data = true;
                    response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.OK;
                }
                else
                {
                    response.Data = false;
                    response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.BadRequest;
                    response.Messages = "Bad Request";
                }
            }
            catch (Exception ex)
            {
                response.Data = false;
                response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.InternalServerError;
                response.Messages = ex.Message;
            }

            return response;
        }
    }
}