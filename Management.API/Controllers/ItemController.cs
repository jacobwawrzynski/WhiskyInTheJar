using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.DTOs;
using Infrastructure.Services;
using AutoMapper;

namespace Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        private IItemService _itemService;
        private IMapper _mapper;

        public ItemController(IItemService itemService, IMapper mapper)
        {
            _itemService = itemService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int? id)
        {
            if (id is null)
            {
                return BadRequest(ModelState);
            }

            var item = _itemService.GetById((int)id);
            return Ok(item);
        }
    }
}
