
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;
    public class ProveedorDireccionController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;

    public ProveedorDireccionController(IUnitOfWork unitofwork, IMapper mapper)
    {
        this.unitofwork = unitofwork;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<IEnumerable<ProveedorDireccionDto>>> Get()
    {
        var proveedorDireccion = await unitofwork.ProveedorDirecciones.GetAllAsync();
        return mapper.Map<List<ProveedorDireccionDto>>(proveedorDireccion);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<ProveedorDireccionDto>> Get(int id)
    {
        var proveedorDireccion = await unitofwork.ProveedorDirecciones.GetByIdAsync(id);
        if (proveedorDireccion == null)
        {
            return NotFound();
        }
        return this.mapper.Map<ProveedorDireccionDto>(proveedorDireccion);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]

    public async Task<ActionResult<ProveedorDireccion>> Post(ProveedorDireccionDto proveedorDireccionDto)
    {
        var proveedorDireccion = this.mapper.Map<ProveedorDireccion>(proveedorDireccionDto);
        this.unitofwork.ProveedorDirecciones.Add(proveedorDireccion);
        await unitofwork.SaveAsync();
        if (proveedorDireccion == null)
        {
            return BadRequest();
        }
        proveedorDireccionDto.Id = proveedorDireccion.Id;
        return CreatedAtAction(nameof(Post), new { id = proveedorDireccionDto.Id }, proveedorDireccionDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<ActionResult<ProveedorDireccionDto>> Put(int id, [FromBody] ProveedorDireccionDto proveedorDireccionDto)
    {
        if (proveedorDireccionDto == null)
        {
            return NotFound();
        }
        var proveedorDireccion = this.mapper.Map<ProveedorDireccion>(proveedorDireccionDto);
        unitofwork.ProveedorDirecciones.Update(proveedorDireccion);
        await unitofwork.SaveAsync();
        return proveedorDireccionDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]

    public async Task<IActionResult> Delete(int id)
    {
        var proveedorDireccion = await unitofwork.ProveedorDirecciones.GetByIdAsync(id);
        if (proveedorDireccion == null)
        {
            return NotFound();
        }
        unitofwork.ProveedorDirecciones.Remove(proveedorDireccion);
        await unitofwork.SaveAsync();
        return NoContent();
    }
    }
