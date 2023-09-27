


using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers
{
    public class MedicamentoVendidoController:ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;

    public MedicamentoVendidoController(IUnitOfWork unitofwork, IMapper mapper)
    {
        this.unitofwork = unitofwork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<MedicamentoVendidoDto>>> Get()
    {
        var medicamentoVendido = await unitofwork.MedicamentoVendidos.GetAllAsync();
        return mapper.Map<List<MedicamentoVendidoDto>>(medicamentoVendido);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<MedicamentoVendidoDto>> Get(int id)
    {
        var medicamentoVendido = await unitofwork.MedicamentoVendidos.GetByIdAsync(id);
        if (medicamentoVendido == null)
        {
            return NotFound();
        }
        return this.mapper.Map<MedicamentoVendidoDto>(medicamentoVendido);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<MedicamentoVendido>> Post(MedicamentoVendidoDto medicamentoVendidoDto)
    {
        var medicamentoVendido = this.mapper.Map<MedicamentoVendido>(medicamentoVendidoDto);
        this.unitofwork.MedicamentoVendidos.Add(medicamentoVendido);
        await unitofwork.SaveAsync();
        if (medicamentoVendido == null)
        {
            return BadRequest();
        }
        medicamentoVendidoDto.Id = medicamentoVendido.Id;
        return CreatedAtAction(nameof(Post), new { id = medicamentoVendidoDto.Id }, medicamentoVendidoDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<MedicamentoVendidoDto>> Put(int id, [FromBody] MedicamentoVendidoDto medicamentoVendidoDto)
    {
        if (medicamentoVendidoDto == null)
        {
            return NotFound();
        }
        var medicamentoVendido = this.mapper.Map<MedicamentoVendido>(medicamentoVendidoDto);
        unitofwork.MedicamentoVendidos.Update(medicamentoVendido);
        await unitofwork.SaveAsync();
        return medicamentoVendidoDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> Delete(int id)
    {
        var medicamentoVendido = await unitofwork.MedicamentoVendidos.GetByIdAsync(id);
        if (medicamentoVendido == null)
        {
            return NotFound();
        }
        unitofwork.MedicamentoVendidos.Remove(medicamentoVendido);
        await unitofwork.SaveAsync();
        return NoContent();
    }
}
}