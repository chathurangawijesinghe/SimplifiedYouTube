using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Commands.Insert
{
    public class InsertCommand : IRequest<bool>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
    }
}
