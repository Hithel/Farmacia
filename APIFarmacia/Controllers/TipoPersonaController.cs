

using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;
    public class TipoPersonaController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public TipoPersonaController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<TipoPersonaDto>>> Get()
        {
            var TipoPersonas = await unitofwork.TipoPersonas.GetAllAsync();
            return mapper.Map<List<TipoPersonaDto>>(TipoPersonas);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoPersonaDto>> Get(int id)
        {
            var TipoPersonas = await unitofwork.TipoPersonas.GetByIdAsync(id);
            if (TipoPersonas == null){
                return NotFound();
            }
            return this.mapper.Map<TipoPersonaDto>(TipoPersonas);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<TipoPersona>> Post(TipoPersonaDto TipoPersonaDto)
        {
            var TipoPersonas = this.mapper.Map<TipoPersona>(TipoPersonaDto);
            this.unitofwork.TipoPersonas.Add(TipoPersonas);
            await unitofwork.SaveAsync();
            if(TipoPersonas == null)
            {
                return BadRequest();
            }
            TipoPersonas.Id = TipoPersonas.Id;
            return CreatedAtAction(nameof(Post), new {id = TipoPersonas.Id}, TipoPersonas);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoPersonaDto>> Put(int id, [FromBody]TipoPersonaDto TipoPersonaDto){
            if(TipoPersonaDto == null)
            {
                return NotFound();
            }
            var TipoPersonas = this.mapper.Map<TipoPersona>(TipoPersonaDto);
            unitofwork.TipoPersonas.Update(TipoPersonas);
            await unitofwork.SaveAsync();
            return TipoPersonaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var TipoPersonas = await unitofwork.TipoPersonas.GetByIdAsync(id);
            if(TipoPersonas == null)
            {
                return NotFound();
            }
            unitofwork.TipoPersonas.Remove(TipoPersonas);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }