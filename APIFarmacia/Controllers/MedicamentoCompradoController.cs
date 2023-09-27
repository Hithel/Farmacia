
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;

    public class MedicamentoCompradoController :ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public MedicamentoCompradoController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<MedicamentoCompradoDto>>> Get()
        {
            var MedicamentoComprado = await unitofwork.MedicamentoComprados.GetAllAsync();
            return mapper.Map<List<MedicamentoCompradoDto>>(MedicamentoComprado);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<MedicamentoCompradoDto>> Get(int id)
        {
            var MedicamentoComprado = await unitofwork.MedicamentoComprados.GetByIdAsync(id);
            if (MedicamentoComprado == null){
                return NotFound();
            }
            return this.mapper.Map<MedicamentoCompradoDto>(MedicamentoComprado);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<MedicamentoComprado>> Post(MedicamentoCompradoDto MedicamentoCompradoDto)
        {
            var MedicamentoComprado = this.mapper.Map<MedicamentoComprado>(MedicamentoCompradoDto);
            this.unitofwork.MedicamentoComprados.Add(MedicamentoComprado);
            await unitofwork.SaveAsync();
            if(MedicamentoComprado == null)
            {
                return BadRequest();
            }
            MedicamentoCompradoDto.Id = MedicamentoComprado.Id;
            return CreatedAtAction(nameof(Post), new {id = MedicamentoComprado.Id}, MedicamentoComprado);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<MedicamentoCompradoDto>> Put(int id, [FromBody]MedicamentoCompradoDto MedicamentoCompradoDto){
            if(MedicamentoCompradoDto == null)
            {
                return NotFound();
            }
            var MedicamentoComprados = this.mapper.Map<MedicamentoComprado>(MedicamentoCompradoDto);
            unitofwork.MedicamentoComprados.Update(MedicamentoComprados);
            await unitofwork.SaveAsync();
            return MedicamentoCompradoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var MedicamentoComprados = await unitofwork.MedicamentoComprados.GetByIdAsync(id);
            if(MedicamentoComprados == null)
            {
                return NotFound();
            }
            unitofwork.MedicamentoComprados.Remove(MedicamentoComprados);
            await unitofwork.SaveAsync();
            return NoContent();
        }


    }
