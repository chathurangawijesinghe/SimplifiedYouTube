using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capgemini.SimplifiedYouTube.Core.Application.Videos.Videos.Commands.Insert
{
    public class InsertCommandValidator : AbstractValidator<InsertCommand>
    {
        public InsertCommandValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(200);
            RuleFor(x => x.FileName).NotEmpty();
        }
    }
}
