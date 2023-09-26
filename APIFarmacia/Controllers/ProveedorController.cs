

using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;
    public class ProveedorController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public ProveedorController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<ProveedorDto>>> Get()
        {
            var Proveedor = await unitofwork.Proveedores.GetAllAsync();
            return mapper.Map<List<ProveedorDto>>(Proveedor);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProveedorDireccionDto>> Get(int id)
        {
            var Proveedor = await unitofwork.Proveedores.GetByIdAsync(id);
            if (Proveedor == null){
                return NotFound();
            }
            return this.mapper.Map<ProveedorDireccionDto>(Proveedor);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Proveedor>> Post(ProveedorDto ProveedorDto)
        {
            var Proveedor = this.mapper.Map<Proveedor>(ProveedorDto);
            this.unitofwork.Proveedores.Add(Proveedor);
            await unitofwork.SaveAsync();
            if(Proveedor == null)
            {
                return BadRequest();
            }
            ProveedorDto.Id = Proveedor.Id;
            return CreatedAtAction(nameof(Post), new {id = Proveedor.Id}, Proveedor);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<ProveedorDto>> Put(int id, [FromBody]ProveedorDto ProveedorDto){
            if(ProveedorDto == null)
            {
                return NotFound();
            }
            var Proveedores = this.mapper.Map<Proveedor>(ProveedorDto);
            unitofwork.Proveedores.Update(Proveedores);
            await unitofwork.SaveAsync();
            return ProveedorDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var Proveedores = await unitofwork.Proveedores.GetByIdAsync(id);
            if(Proveedores == null)
            {
                return NotFound();
            }
            unitofwork.Proveedores.Remove(Proveedores);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
