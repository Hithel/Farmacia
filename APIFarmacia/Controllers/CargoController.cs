/* 
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;

    public class CargoController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;
    
        public CargoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitofwork = unitOfWork;

            this.mapper = mapper;
        }
    
    
    [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<CargoDto>>> Get()
        {
            var Cargos = await unitofwork.Cargos.GetAllAsync();
            return mapper.Map<List<CargoDto>>(Cargos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<CargoDto>> Get(int id)
        {
            var Cargos = await unitofwork.Cargos.GetByIdAsync(id);
            if (Cargos == null){
                return NotFound();
            }
            return this.mapper.Map<CargoDto>(Cargos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Cargo>> Post(CargoDto CargoDto)
        {
            var Cargos = this.mapper.Map<ProveedorDireccion>(CargoDto);
            this.unitofwork.Cargos.Add(Cargos);
            await unitofwork.SaveAsync();
            if(Cargos == null)
            {
                return BadRequest();
            }
            CargoDto.Id = Cargos.Id;
            return CreatedAtAction(nameof(Post), new {id = Cargos.Id}, Cargos);
        }
        
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<CargoDto>> Put(int id, [FromBody]CargoDto CargoDto){
            if(CargoDto == null)
            {
                return NotFound();
            }
            var Cargos = this.mapper.Map<Cargo>(CargoDto);
            unitofwork.Cargos.Update(Cargos);
            await unitofwork.SaveAsync();
            return CargoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var Cargos = await unitofwork.Cargos.GetByIdAsync(id);
            if(Cargos == null)
            {
                return NotFound();
            }
            unitofwork.Cargos.Remove(Cargos);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    } */