using AutoMapper;
using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using Capgemini.SimplifiedYouTube.Services.IVideos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll
{
    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, VideosDto>
    {
        private IMapper mapper;
        private IVideoService videoService;

        public GetAllQueryHandler(IVideoService videoService, IMapper mapper)
        {
            this.videoService = videoService;
            this.mapper = mapper;
        }

        public async Task<VideosDto> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var validator = new GetAllQueryValidator();
            var results = validator.Validate(request);

            if (results.IsValid)
            {
                var data = await videoService.GetAll();

                var convertedData = mapper.Map<List<VideoDto>>(data);

                return new VideosDto() { Videos = convertedData }; 
            }
            else
            {
                return null;
            }
        }
    }
}
