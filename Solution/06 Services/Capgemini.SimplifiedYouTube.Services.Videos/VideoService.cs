using AutoMapper;
using Capgemini.SimplifiedYouTube.Contexts.Videos;
using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using Capgemini.SimplifiedYouTube.Repositories.IVideos;
using Capgemini.SimplifiedYouTube.Services.IVideos;
using Kaddis.Framework.Utilities.Service;
using System;

namespace Capgemini.SimplifiedYouTube.Services.Videos
{ 
    public class VideoService : GenericService<Video, VideoEntity>, IVideoService
    {
        private readonly IVideoRepository unitOfWork;
        private readonly IMapper mapper;

        public VideoService(IVideoRepository unitOfWork, IMapper mapper) : base(unitOfWork, mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
    }
}
