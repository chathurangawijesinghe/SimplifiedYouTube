using Capgemini.SimplifiedYouTube.Contexts.Videos;
using Capgemini.SimplifiedYouTube.Repositories.IVideos;
using Kaddis.Framework.Utilities.Repository;
using Microsoft.EntityFrameworkCore;
using System;

namespace Capgemini.SimplifiedYouTube.Repositories.Videos
{
    public class VideoRepository : GenericRepository<VideoEntity>, IVideoRepository
    {
        public VideoRepository(DbContext context) : base(context)
        {
        }
    }
}
