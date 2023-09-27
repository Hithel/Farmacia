
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;

    public class PaisController:ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public PaisController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<PaisDto>>> Get()
        {
            var Pais = await unitofwork.Paises.GetAllAsync();
            return mapper.Map<List<PaisDto>>(Pais);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PaisDto>> Get(int id)
        {
            var Pais = await unitofwork.Paises.GetByIdAsync(id);
            if (Pais == null){
                return NotFound();
            }
            return this.mapper.Map<PaisDto>(Pais);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Pais>> Post(PaisDto PaisDto)
        {
            var Pais = this.mapper.Map<Pais>(PaisDto);
            this.unitofwork.Paises.Add(Pais);
            await unitofwork.SaveAsync();
            if(Pais == null)
            {
                return BadRequest();
            }
            PaisDto.Id = Pais.Id;
            return CreatedAtAction(nameof(Post), new {id = Pais.Id}, Pais);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PaisDto>> Put(int id, [FromBody]PaisDto PaisDto){
            if(PaisDto == null)
            {
                return NotFound();
            }
            var Paises = this.mapper.Map<Pais>(PaisDto);
            unitofwork.Paises.Update(Paises);
            await unitofwork.SaveAsync();
            return PaisDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var Paises = await unitofwork.Paises.GetByIdAsync(id);
            if(Paises == null)
            {
                return NotFound();
            }
            unitofwork.Paises.Remove(Paises);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
