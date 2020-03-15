using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using Microsoft.EntityFrameworkCore;
using System;

namespace Capgemini.SimplifiedYouTube.Contexts.Videos
{
    public class VideoContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
    }
}
