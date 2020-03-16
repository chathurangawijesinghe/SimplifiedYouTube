using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll
{
    public class VideosDto
    {
        public VideosDto()
        {
            Videos = new List<VideoDto>();
        }

        public List<VideoDto> Videos { get; set; }
    }
}
