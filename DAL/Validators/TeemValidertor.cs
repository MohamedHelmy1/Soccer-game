using DAL.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Validators
{
    public class TeemValidertor:AbstractValidator<TeemViewModel>
    {
        public TeemValidertor()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x=>x.CoachName).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Foundationdate).NotEmpty().WithMessage("Name cannot be empty");
            RuleFor(x => x.Country).NotEmpty().WithMessage("Name cannot be empty");
     

        }
    }
}
