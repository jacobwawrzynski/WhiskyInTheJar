﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.DTOs;
using Infrastructure.Services;
using AutoMapper;
using Infrastructure.Entities;

namespace Management.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WhiskyController : ControllerBase
    {
        private IWhiskyService _whiskyService;
        private IMapper _mapper;

        public WhiskyController(IWhiskyService whiskyService, IMapper mapper)
        {
            _whiskyService = whiskyService;
            _mapper = mapper;
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid? id)
        {
            if (id is null)
            {
                return BadRequest(ModelState);
            }

            var item = _whiskyService.GetById((Guid)id);
            return Ok(item);
        }

        [HttpGet]
        public IActionResult GetAll() 
        {
            var items = _whiskyService.SortByStarsDesc();
            return Ok(items);
        }

        [HttpPost]
        public IActionResult Create(WhiskyDTO whiskyDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            var whisky = _mapper.Map<Whisky>(whiskyDTO);
            _whiskyService.Create(whisky);
            _whiskyService.Save();
            return Ok(whisky);
        }

        [HttpPatch("{id}")]
        public IActionResult Edit(Guid? id, WhiskyDTO whiskyDTO)
        {
            if (id is null)
            {
                return BadRequest("id is null");
            }

            var whisky = _whiskyService.GetById((Guid) id);

            if (whisky is null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            whisky = _mapper.Map<Whisky>(whiskyDTO);
            _whiskyService.Update(whisky);
            _whiskyService.Save();
            return Ok(whisky);
        }

        [HttpDelete]
        public IActionResult Delete(Guid? id)
        {
            if (id is null)
            {
                return BadRequest("id is null");
            }

            var whisky = _whiskyService.GetById((Guid)id); 

            if (whisky is null)
            {
                return NotFound();
            }

            _whiskyService.Delete(whisky);
            _whiskyService.Save();
            return Ok(whisky);
        }
    }
}
