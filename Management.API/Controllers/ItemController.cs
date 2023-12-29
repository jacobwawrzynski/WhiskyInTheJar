using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.DTOs;

namespace Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

        }
    }
}
