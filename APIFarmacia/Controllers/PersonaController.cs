using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers
{
    public class PersonaController:ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public PersonaController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<PersonaDto>>> Get()
        {
            var Persona = await unitofwork.Personas.GetAllAsync();
            return mapper.Map<List<PersonaDto>>(Persona);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PersonaDto>> Get(int id)
        {
            var Persona = await unitofwork.Personas.GetByIdAsync(id);
            if (Persona == null){
                return NotFound();
            }
            return this.mapper.Map<PersonaDto>(Persona);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Persona>> Post(PersonaDto PersonaDto)
        {
            var Persona = this.mapper.Map<Persona>(PersonaDto);
            this.unitofwork.Personas.Add(Persona);
            await unitofwork.SaveAsync();
            if(Persona == null)
            {
                return BadRequest();
            }
            PersonaDto.Id = Persona.Id;
            return CreatedAtAction(nameof(Post), new {id = Persona.Id}, Persona);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PersonaDto>> Put(int id, [FromBody]PersonaDto PersonaDto){
            if(PersonaDto == null)
            {
                return NotFound();
            }
            var Personas = this.mapper.Map<Persona>(PersonaDto);
            unitofwork.Personas.Update(Personas);
            await unitofwork.SaveAsync();
            return PersonaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var Personas = await unitofwork.Personas.GetByIdAsync(id);
            if(Personas == null)
            {
                return NotFound();
            }
            unitofwork.Personas.Remove(Personas);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
}