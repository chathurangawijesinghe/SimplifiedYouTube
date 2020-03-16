using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll
{
    public class VideoDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoName { get; set; }
        public string BasePath { get; set; }
    }
}
