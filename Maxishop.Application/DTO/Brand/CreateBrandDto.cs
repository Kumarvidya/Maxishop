﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maxishop.Application.DTO.Brand
{
   public class CreateBrandDto
    {
        public string Name { get; set; }
        public int EstablishedYear { get; set; }

    }
    public class CreateBrandDtoValidator : AbstractValidator<CreateBrandDto>
    {
        public CreateBrandDtoValidator() 
        {
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x=>x.EstablishedYear).InclusiveBetween(1950,DateTime.UtcNow.Year);
        }
    }

}
