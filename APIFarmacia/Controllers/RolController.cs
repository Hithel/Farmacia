

using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers
{
    public class RolController:ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public RolController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<RolDto>>> Get()
        {
            var Rol = await unitofwork.Roles.GetAllAsync();
            return mapper.Map<List<RolDto>>(Rol);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<RolDto>> Get(int id)
        {
            var Rol = await unitofwork.Roles.GetByIdAsync(id);
            if (Rol == null){
                return NotFound();
            }
            return this.mapper.Map<RolDto>(Rol);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Rol>> Post(RolDto RolDto)
        {
            var Rol = this.mapper.Map<Rol>(RolDto);
            this.unitofwork.Roles.Add(Rol);
            await unitofwork.SaveAsync();
            if(Rol == null)
            {
                return BadRequest();
            }
            RolDto.Id = Rol.Id;
            return CreatedAtAction(nameof(Post), new {id = Rol.Id}, Rol);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<RolDto>> Put(int id, [FromBody]RolDto RolDto){
            if(RolDto == null)
            {
                return NotFound();
            }
            var Roles = this.mapper.Map<Rol>(RolDto);
            unitofwork.Roles.Update(Roles);
            await unitofwork.SaveAsync();
            return RolDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var Roles = await unitofwork.Roles.GetByIdAsync(id);
            if(Roles == null)
            {
                return NotFound();
            }
            unitofwork.Roles.Remove(Roles);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
}