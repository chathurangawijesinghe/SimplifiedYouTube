using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.SimplifiedYouTube.Common.Protos.Videos;
using Capgemini.SimplifiedYouTube.Facades.IVideos;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Capgemini.SimplifiedYouTube.APIs.Videos.Controllers
{
    [Route("api/[controller]")]
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
        public List<Video> Index()
        {
            return _videosFacade.GetAll();
        }
    }
}