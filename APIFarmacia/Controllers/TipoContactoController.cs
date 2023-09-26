

using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;
    public class TipoContactoController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public TipoContactoController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<TipoContactoDto>>> Get()
        {
            var TipoContactos = await unitofwork.TipoContactos.GetAllAsync();
            return mapper.Map<List<TipoContactoDto>>(TipoContactos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoContactoDto>> Get(int id)
        {
            var TipoContactos = await unitofwork.TipoContactos.GetByIdAsync(id);
            if (TipoContactos == null){
                return NotFound();
            }
            return this.mapper.Map<TipoContactoDto>(TipoContactos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<TipoContacto>> Post(TipoContactoDto TipoContactoDto)
        {
            var TipoContactos = this.mapper.Map<TipoContacto>(TipoContactoDto);
            this.unitofwork.TipoContactos.Add(TipoContactos);
            await unitofwork.SaveAsync();
            if(TipoContactos == null)
            {
                return BadRequest();
            }
            TipoContactos.Id = TipoContactos.Id;
            return CreatedAtAction(nameof(Post), new {id = TipoContactos.Id}, TipoContactos);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoContactoDto>> Put(int id, [FromBody]TipoContactoDto TipoContactoDto){
            if(TipoContactoDto == null)
            {
                return NotFound();
            }
            var TipoContactos = this.mapper.Map<TipoContacto>(TipoContactoDto);
            unitofwork.TipoContactos.Update(TipoContactos);
            await unitofwork.SaveAsync();
            return TipoContactoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var TipoContactos = await unitofwork.TipoContactos.GetByIdAsync(id);
            if(TipoContactos == null)
            {
                return NotFound();
            }
            unitofwork.TipoContactos.Remove(TipoContactos);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
