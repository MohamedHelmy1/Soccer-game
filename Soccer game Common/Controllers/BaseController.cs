
namespace Soccer_game_Common
{
    using AutoMapper;
    using FluentValidation;
    using FluentValidation.Results;
    using Microsoft.AspNetCore.Mvc;

    public class BaseController<TEntity, TViewModel> : ControllerBase
        where TEntity : BaseEntity
        where TViewModel : class
    {
        protected readonly IBaseUnitOfWork<TEntity> _unitOfWork;
        protected readonly IMapper _mapper;
        protected readonly IValidator<TViewModel> _validator;

        public BaseController(IBaseUnitOfWork<TEntity> unitOfWork, IMapper mapper, IValidator<TViewModel> validator)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validator = validator;
        }

        [HttpGet]
        public virtual async Task<IEnumerable<TViewModel>> Get()
        {
            List<TEntity> entities = await _unitOfWork.ReadAsync();
            return entities.Select(product => _mapper.Map<TViewModel>(product));
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> Get(Guid id)
        {
            TEntity product = await _unitOfWork.ReadByIdAsync(id);
            TViewModel TypeViewModel = _mapper.Map<TViewModel>(product);
            return Ok(TypeViewModel);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Post([FromBody] TViewModel TypeViewModel)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(TypeViewModel);
            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });
            
            var product = _mapper.Map<TEntity>(TypeViewModel);
            product = await _unitOfWork.CreateAsync(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, _mapper.Map<TViewModel>(product));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] TViewModel TypeViewModel)
        {
            ValidationResult validationResult = await _validator.ValidateAsync(TypeViewModel);
            if (!validationResult.IsValid)
                return BadRequest(new { errors = validationResult.Errors });

            var product = _mapper.Map<TEntity>(TypeViewModel);
            product = await _unitOfWork.UpdateAsync(product);
            return Ok(_mapper.Map<TViewModel>(product));
        }

        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _unitOfWork.DeleteAsync(id);
        }
    }
}