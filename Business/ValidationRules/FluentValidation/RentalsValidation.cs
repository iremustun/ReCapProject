using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalsValidation : AbstractValidator<Rentals>
    {
        public RentalsValidation()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.CustomerId).NotEmpty();
            RuleFor(p => p.RentalDate).NotEmpty();
        }
    }
    }
}
