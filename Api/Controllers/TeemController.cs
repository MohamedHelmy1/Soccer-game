using AutoMapper;
using DAL.Entities;
using DAL.ViewModel;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Soccer_game_Common;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeemController : BaseController<Teem, TeemViewModel>
    {
        public TeemController(IBaseUnitOfWork<Teem> unitOfWork, IMapper mapper, IValidator<TeemViewModel> validator) : base(unitOfWork, mapper, validator)
        {
        }
        public override Task<IActionResult> Post(TeemViewModel teem)
        {
            teem.LogoPath = "1";
            return base.Post(teem);
        }
    }
}
