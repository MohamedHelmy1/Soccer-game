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
    public class PlayerController : BaseController<player, PlayerViewModel>
    {
        public PlayerController(IBaseUnitOfWork<player> unitOfWork, IMapper mapper, IValidator<PlayerViewModel> validator) : base(unitOfWork, mapper, validator)
        {
        }

        public override Task<IActionResult> Post(PlayerViewModel player)
        {
            player.ImagePath = "1";
            return base.Post(player);
        }
    }
}
