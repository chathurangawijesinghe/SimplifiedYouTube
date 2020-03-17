using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Facades.IVideos
{
    public class InsertVideoDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
        public IFormFile File { get; set; }
    }
}
