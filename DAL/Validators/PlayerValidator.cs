using DAL.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Validators
{
    public class PlayerValidator:AbstractValidator<PlayerViewModel>
    {
        public PlayerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x=>x.DateOfBirth).NotEmpty().WithMessage("DateOfBirth cannot be empty");
            RuleFor(x => x.Nationality).NotEmpty().WithMessage("Nationality cannot be empty");
           

        }
    }
}
