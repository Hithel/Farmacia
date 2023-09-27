
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers
{
    public class PersonaContactoController :ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public PersonaContactoController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<PersonaContactoDto>>> Get()
        {
            var PersonaContacto = await unitofwork.PersonaContactos.GetAllAsync();
            return mapper.Map<List<PersonaContactoDto>>(PersonaContacto);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PersonaContactoDto>> Get(int id)
        {
            var PersonaContacto = await unitofwork.PersonaContactos.GetByIdAsync(id);
            if (PersonaContacto == null){
                return NotFound();
            }
            return this.mapper.Map<PersonaContactoDto>(PersonaContacto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<PersonaContacto>> Post(PersonaContactoDto PersonaContactoDto)
        {
            var PersonaContacto = this.mapper.Map<PersonaContacto>(PersonaContactoDto);
            this.unitofwork.PersonaContactos.Add(PersonaContacto);
            await unitofwork.SaveAsync();
            if(PersonaContacto == null)
            {
                return BadRequest();
            }
            PersonaContactoDto.Id = PersonaContacto.Id;
            return CreatedAtAction(nameof(Post), new {id = PersonaContacto.Id}, PersonaContacto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PersonaContactoDto>> Put(int id, [FromBody]PersonaContactoDto PersonaContactoDto){
            if(PersonaContactoDto == null)
            {
                return NotFound();
            }
            var PersonaContactos = this.mapper.Map<PersonaContacto>(PersonaContactoDto);
            unitofwork.PersonaContactos.Update(PersonaContactos);
            await unitofwork.SaveAsync();
            return PersonaContactoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var PersonaContactos = await unitofwork.PersonaContactos.GetByIdAsync(id);
            if(PersonaContactos == null)
            {
                return NotFound();
            }
            unitofwork.PersonaContactos.Remove(PersonaContactos);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
}