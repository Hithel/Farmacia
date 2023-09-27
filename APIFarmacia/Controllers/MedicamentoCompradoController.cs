
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;

    public class MedicamentoCompradoController :ApiBaseController
    {
    private readonly IUnitOfWork unitofwork;
    private readonly  IMapper mapper;

    public MedicamentoCompradoController(IUnitOfWork unitofwork, IMapper mapper)
    {
        this.unitofwork = unitofwork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<MedicamentoCompradoDto>>> Get()
    {
        var medicamentoComprado = await unitofwork.MedicamentoComprados.GetAllAsync();
        return mapper.Map<List<MedicamentoCompradoDto>>(medicamentoComprado);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<MedicamentoCompradoDto>> Get(int id)
    {
        var medicamentoComprado = await unitofwork.MedicamentoComprados.GetByIdAsync(id);
        if (medicamentoComprado == null){
            return NotFound();
        }
        return this.mapper.Map<MedicamentoCompradoDto>(medicamentoComprado);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<MedicamentoComprado>> Post(MedicamentoCompradoDto medicamentoCompradoDto)
    {
        var medicamentoComprado = this.mapper.Map<MedicamentoComprado>(medicamentoCompradoDto);
        this.unitofwork.MedicamentoComprados.Add(medicamentoComprado);
        await unitofwork.SaveAsync();
        if(medicamentoComprado == null)
        {
            return BadRequest();
        }
        medicamentoCompradoDto.Id = medicamentoComprado.Id;
        return CreatedAtAction(nameof(Post), new {id = medicamentoCompradoDto.Id}, medicamentoCompradoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<MedicamentoCompradoDto>> Put(int id, [FromBody]MedicamentoCompradoDto medicamentoCompradoDto){
        if(medicamentoCompradoDto == null)
        {
            return NotFound();
        }
        var medicamentoComprado = this.mapper.Map<MedicamentoComprado>(medicamentoCompradoDto);
        unitofwork.MedicamentoComprados.Update(medicamentoComprado);
        await unitofwork.SaveAsync();
        return medicamentoCompradoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> Delete(int id){
        var medicamentoComprado = await unitofwork.MedicamentoComprados.GetByIdAsync(id);
        if(medicamentoComprado == null)
        {
            return NotFound();
        }
        unitofwork.MedicamentoComprados.Remove(medicamentoComprado);
        await unitofwork.SaveAsync();
        return NoContent();
    }


    }
