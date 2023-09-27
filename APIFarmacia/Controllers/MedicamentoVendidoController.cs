


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
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<MedicamentoVendidoDto>>> Get()
        {
            var MedicamentoVendido = await unitofwork.MedicamentoVendidos.GetAllAsync();
            return mapper.Map<List<MedicamentoVendidoDto>>(MedicamentoVendido);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<MedicamentoVendidoDto>> Get(int id)
        {
            var MedicamentoVendido = await unitofwork.MedicamentoVendidos.GetByIdAsync(id);
            if (MedicamentoVendido == null){
                return NotFound();
            }
            return this.mapper.Map<MedicamentoVendidoDto>(MedicamentoVendido);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<MedicamentoVendido>> Post(MedicamentoVendidoDto MedicamentoVendidoDto)
        {
            var MedicamentoVendido = this.mapper.Map<MedicamentoVendido>(MedicamentoVendidoDto);
            this.unitofwork.MedicamentoVendidos.Add(MedicamentoVendido);
            await unitofwork.SaveAsync();
            if(MedicamentoVendido == null)
            {
                return BadRequest();
            }
            MedicamentoVendidoDto.Id = MedicamentoVendido.Id;
            return CreatedAtAction(nameof(Post), new {id = MedicamentoVendido.Id}, MedicamentoVendido);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<MedicamentoVendidoDto>> Put(int id, [FromBody]MedicamentoVendidoDto MedicamentoVendidoDto){
            if(MedicamentoVendidoDto == null)
            {
                return NotFound();
            }
            var MedicamentoVendidos = this.mapper.Map<MedicamentoVendido>(MedicamentoVendidoDto);
            unitofwork.MedicamentoVendidos.Update(MedicamentoVendidos);
            await unitofwork.SaveAsync();
            return MedicamentoVendidoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var MedicamentoVendidos = await unitofwork.MedicamentoVendidos.GetByIdAsync(id);
            if(MedicamentoVendidos == null)
            {
                return NotFound();
            }
            unitofwork.MedicamentoVendidos.Remove(MedicamentoVendidos);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
}