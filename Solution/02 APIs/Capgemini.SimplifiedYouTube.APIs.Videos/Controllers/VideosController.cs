using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
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
        public WebHttpResponse<List<GetAllVideoDto>> Index()
        {
            WebHttpResponse<List<GetAllVideoDto>> response = new WebHttpResponse<List<GetAllVideoDto>>();

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
        public async Task<WebHttpResponse<bool>> Upload([FromForm]InsertVideoDto video)
        {
            WebHttpResponse<bool> response = new WebHttpResponse<bool>();

            try
            {
                var filePath = Path.Combine(@"C:\Users\c.wijesinghe\Desktop\SimplifiedYouTube\Solution\01 Clients\Capgemini.SimplifiedYouTube.Clients.ReactApp\ClientApp\public\videos", video.File.FileName); //we are using Temp file name just for the example. Add your own file path.

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await video.File.CopyToAsync(stream);
                }

                var result = _videosFacade.Insert(video);

                if (result)
                {
                    response.Data = true;
                    response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.OK;
                }
                else
                {
                    response.Data = false;
                    response.ResponseCode = Kaddis.Framework.Utilities.Entities.StatusCode.BadRequest;
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