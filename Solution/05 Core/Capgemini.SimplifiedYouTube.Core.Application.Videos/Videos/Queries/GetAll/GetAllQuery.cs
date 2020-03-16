using Capgemini.SimplifiedYouTube.Core.Domain.Videos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll
{
    public class GetAllQuery : IRequest<VideosDto>
    {
    }
}
