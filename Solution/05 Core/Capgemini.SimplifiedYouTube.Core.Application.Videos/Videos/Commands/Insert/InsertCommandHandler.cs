using AutoMapper;
using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using Capgemini.SimplifiedYouTube.Services.IVideos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Commands.Insert
{
    public class InsertCommandHandler : IRequestHandler<InsertCommand, bool>
    {
        private IMapper mapper;
        private IVideoService videoService;

        public InsertCommandHandler(IVideoService videoService, IMapper mapper)
        {
            this.videoService = videoService;
            this.mapper = mapper;
        }

        public async Task<bool> Handle(InsertCommand request, CancellationToken cancellationToken)
        {
            var validator = new InsertCommandValidator();
            var results = validator.Validate(request);

            if (results.IsValid)
            {
                var data = new Video() { Name = request.Name, 
                                        Description = request.Description, 
                                        FileName = request.FileName,
                                        BasePath = @"/" };
                var result = await videoService.Insert(data);

                return result != null ? true : false;
            }
            else
            {
                return false;
            }
        }
    }
}
