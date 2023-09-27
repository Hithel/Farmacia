
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;

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
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<PersonaContactoDto>>> Get()
    {
        var personaContacto = await unitofwork.PersonaContactos.GetAllAsync();
        return mapper.Map<List<PersonaContactoDto>>(personaContacto);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<PersonaContactoDto>> Get(int id)
    {
        var personaContacto = await unitofwork.PersonaContactos.GetByIdAsync(id);
        if (personaContacto == null)
        {
            return NotFound();
        }
        return this.mapper.Map<PersonaContactoDto>(personaContacto);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<PersonaContacto>> Post(PersonaContactoDto personaContactoDto)
    {
        var personaContacto = this.mapper.Map<PersonaContacto>(personaContactoDto);
        this.unitofwork.PersonaContactos.Add(personaContacto);
        await unitofwork.SaveAsync();
        if (personaContacto == null)
        {
            return BadRequest();
        }
        personaContactoDto.Id = personaContacto.Id;
        return CreatedAtAction(nameof(Post), new { id = personaContactoDto.Id }, personaContactoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<PersonaContactoDto>> Put(int id, [FromBody] PersonaContactoDto personaContactoDto)
    {
        if (personaContactoDto == null)
        {
            return NotFound();
        }
        var personaContacto = this.mapper.Map<PersonaContacto>(personaContactoDto);
        unitofwork.PersonaContactos.Update(personaContacto);
        await unitofwork.SaveAsync();
        return personaContactoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> Delete(int id)
    {
        var personaContacto = await unitofwork.PersonaContactos.GetByIdAsync(id);
        if (personaContacto == null)
        {
            return NotFound();
        }
        unitofwork.PersonaContactos.Remove(personaContacto);
        await unitofwork.SaveAsync();
        return NoContent();
    }
    }
