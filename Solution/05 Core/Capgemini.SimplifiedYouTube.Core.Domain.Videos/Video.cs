using System;

namespace Capgemini.SimplifiedYouTube.Core.Domain.Videos
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string VideoName { get; set; }
        public string BasePath { get; set; }
    }
}
