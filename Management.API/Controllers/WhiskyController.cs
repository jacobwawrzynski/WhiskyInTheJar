using AutoMapper;
using Infrastructure.DTOs;
using Infrastructure.Entities;
using Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;


namespace Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhiskyController : ControllerBase
    {
        private readonly IWhiskyService _whiskyService;
        private readonly IMapper _mapper;

        public WhiskyController(IWhiskyService whiskyService, IMapper mapper)
        {
            _whiskyService = whiskyService;
            _mapper = mapper;
        }

        // GET: api/Whisky
        [HttpGet]
        public ActionResult<IEnumerable<WhiskyDTO>> GetAll()
        {
            var whiskies = _whiskyService.GetAll();
            var whiskyDTOs = _mapper.Map<IEnumerable<WhiskyDTO>>(whiskies);
            return Ok(whiskyDTOs);
        }

        // GET: api/Whisky/{id}
        [HttpGet("{id}")]
        public ActionResult<WhiskyDTO> Get(Guid id)
        {
            var whisky = _whiskyService.GetById(id);
            if (whisky is null)
            {
                return NotFound();
            }
            var whiskyDTO = _mapper.Map<WhiskyDTO>(whisky);
            return Ok(whiskyDTO);
        }

        // POST: api/Whisky
        [HttpPost]
        public ActionResult<WhiskyDTO> Create(WhiskyDTO whiskyDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var whisky = _mapper.Map<Whisky>(whiskyDTO);
            _whiskyService.Create(whisky);
            _whiskyService.Save();

            return CreatedAtAction(nameof(Get), new { id = whisky.Id }, whiskyDTO);
        }

        // PUT: api/Whisky/{id}
        [HttpPut("{id}")]
        public IActionResult Update(Guid id, WhiskyDTO whiskyDTO)
        {
            if (id != whiskyDTO.Id)
            {
                return BadRequest();
            }
            var whisky = _whiskyService.GetById(id);
            if (whisky is null)
            {
                return NotFound();
            }
            _mapper.Map(whiskyDTO, whisky);
            _whiskyService.Update(whisky);
            _whiskyService.Save();

            return NoContent();
        }

        // DELETE: api/Whisky/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var whisky = _whiskyService.GetById(id);
            if (whisky is null)
            {
                return NotFound();
            }
            _whiskyService.Delete(whisky);
            _whiskyService.Save();

            return NoContent();
        }
    }
}
