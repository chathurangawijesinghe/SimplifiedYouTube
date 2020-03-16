using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Queries.GetAll
{
    public class GetAllQueryValidator : AbstractValidator<GetAllQuery>
    {
        public GetAllQueryValidator()
        {
        }
    }
}
