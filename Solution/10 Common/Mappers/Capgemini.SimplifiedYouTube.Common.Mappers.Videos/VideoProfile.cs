using AutoMapper;
using Capgemini.SimplifiedYouTube.Contexts.Videos;
using Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll;
using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using System;

namespace Capgemini.SimplifiedYouTube.Common.Mappers.Videos
{
    public class VideoProfile : Profile
    {
        public VideoProfile()
        {
            CreateMap<VideoEntity, Video>();
            CreateMap<Video, VideoEntity>();
            CreateMap<Video, VideoDto>();
        }
    }
}
