using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using Microsoft.EntityFrameworkCore;
using System;

namespace Capgemini.SimplifiedYouTube.Contexts.Videos
{
    public class VideoContext : DbContext
    {
        public VideoContext(DbContextOptions<VideoContext> options) : base(options)
        {
        }

        public DbSet<VideoEntity> Videos { get; set; }
    }
}
