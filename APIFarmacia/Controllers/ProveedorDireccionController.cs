
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
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<ProveedorDireccionDto>>> Get()
        {
            var ProveedorDirecciones = await unitofwork.ProveedorDirecciones.GetAllAsync();
            return mapper.Map<List<ProveedorDireccionDto>>(ProveedorDirecciones);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProveedorDireccionDto>> Get(int id)
        {
            var ProveedorDirecciones = await unitofwork.ProveedorDirecciones.GetByIdAsync(id);
            if (ProveedorDirecciones == null){
                return NotFound();
            }
            return this.mapper.Map<ProveedorDireccionDto>(ProveedorDirecciones);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ProveedorDireccion>> Post(ProveedorDireccionDto ProveedorDireccionDto)
        {
            var ProveedorDirecciones = this.mapper.Map<ProveedorDireccion>(ProveedorDireccionDto);
            this.unitofwork.ProveedorDirecciones.Add(ProveedorDirecciones);
            await unitofwork.SaveAsync();
            if(ProveedorDirecciones == null)
            {
                return BadRequest();
            }
            ProveedorDireccionDto.Id = ProveedorDirecciones.Id;
            return CreatedAtAction(nameof(Post), new {id = ProveedorDirecciones.Id}, ProveedorDirecciones);
        }
        
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProveedorDireccionDto>> Put(int id, [FromBody]ProveedorDireccionDto ProveedorDireccionDto){
            if(ProveedorDireccionDto == null)
            {
                return NotFound();
            }
            var ProveedorDirecciones = this.mapper.Map<ProveedorDireccion>(ProveedorDireccionDto);
            unitofwork.ProveedorDirecciones.Update(ProveedorDirecciones);
            await unitofwork.SaveAsync();
            return ProveedorDireccionDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var ProveedorDirecciones = await unitofwork.ProveedorDirecciones.GetByIdAsync(id);
            if(ProveedorDirecciones == null)
            {
                return NotFound();
            }
            unitofwork.ProveedorDirecciones.Remove(ProveedorDirecciones);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
