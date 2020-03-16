using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capgemini.SimplifiedYouTube.Common.Protos.Videos;
using Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll;
using Grpc.Core;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Capgemini.SimplifiedYouTube.gRPCService.Videos.Services
{
    public class VideoService : Common.Protos.Videos.Videos.VideosBase
    {
        private readonly ILogger<VideoService> _logger;
        private IMediator _mediator;

        public VideoService(ILogger<VideoService> logger, IMediator mediator)
        {
            _logger = logger;
            _mediator = mediator;
        }

        public async override Task<GetAllReply> GetAll(GetAllRequest request, ServerCallContext context)
        {
            GetAllQuery query = new GetAllQuery();
            var allData = await _mediator.Send(query);

            var result = new GetAllReply();

            foreach (var data in allData.Videos)
            {
                result.Videos.Add(new Video() { Id = data.Id, Name = data.Name, Description = data.Description });
            }

            return result;
        }
    }
}
