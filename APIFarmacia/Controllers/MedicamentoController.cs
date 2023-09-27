


using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;

    public class MedicamentoController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public MedicamentoController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<MedicamentoDto>>> Get()
        {
            var Medicamento = await unitofwork.Medicamentos.GetAllAsync();
            return mapper.Map<List<MedicamentoDto>>(Medicamento);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<MedicamentoDto>> Get(int id)
        {
            var Medicamento = await unitofwork.Medicamentos.GetByIdAsync(id);
            if (Medicamento == null){
                return NotFound();
            }
            return this.mapper.Map<MedicamentoDto>(Medicamento);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Medicamento>> Post(MedicamentoDto MedicamentoDto)
        {
            var Medicamento = this.mapper.Map<Medicamento>(MedicamentoDto);
            this.unitofwork.Medicamentos.Add(Medicamento);
            await unitofwork.SaveAsync();
            if(Medicamento == null)
            {
                return BadRequest();
            }
            MedicamentoDto.Id = Medicamento.Id;
            return CreatedAtAction(nameof(Post), new {id = Medicamento.Id}, Medicamento);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<MedicamentoDto>> Put(int id, [FromBody]MedicamentoDto MedicamentoDto){
            if(MedicamentoDto == null)
            {
                return NotFound();
            }
            var Medicamentos = this.mapper.Map<Medicamento>(MedicamentoDto);
            unitofwork.Medicamentos.Update(Medicamentos);
            await unitofwork.SaveAsync();
            return MedicamentoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var Medicamentos = await unitofwork.Medicamentos.GetByIdAsync(id);
            if(Medicamentos == null)
            {
                return NotFound();
            }
            unitofwork.Medicamentos.Remove(Medicamentos);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }
