
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;
    public class TipoDocumentoController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public TipoDocumentoController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<TipoDocumentoDto>>> Get()
        {
            var TipoDocumento = await unitofwork.TipoDocumentos.GetAllAsync();
            return mapper.Map<List<TipoDocumentoDto>>(TipoDocumento);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoDocumentoDto>> Get(int id)
        {
            var TipoDocumentos = await unitofwork.TipoDocumentos.GetByIdAsync(id);
            if (TipoDocumentos == null){
                return NotFound();
            }
            return this.mapper.Map<TipoDocumentoDto>(TipoDocumentos);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<TipoDocumento>> Post(TipoDocumentoDto TipoDocumentoDto)
        {
            var TipoDocumentos = this.mapper.Map<TipoDocumento>(TipoDocumentoDto);
            this.unitofwork.TipoDocumentos.Add(TipoDocumentos);
            await unitofwork.SaveAsync();
            if(TipoDocumentos == null)
            {
                return BadRequest();
            }
            TipoDocumentos.Id = TipoDocumentos.Id;
            return CreatedAtAction(nameof(Post), new {id = TipoDocumentos.Id}, TipoDocumentos);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<TipoContactoDto>> Put(int id, [FromBody]TipoContactoDto TipoContactoDto){
            if(TipoContactoDto == null)
            {
                return NotFound();
            }
            var TipoDocumentos = this.mapper.Map<TipoDocumento>(TipoContactoDto);
            unitofwork.TipoDocumentos.Update(TipoDocumentos);
            await unitofwork.SaveAsync();
            return TipoContactoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Delete(int id){
            var TipoDocumentos = await unitofwork.TipoDocumentos.GetByIdAsync(id);
            if(TipoDocumentos == null)
            {
                return NotFound();
            }
            unitofwork.TipoDocumentos.Remove(TipoDocumentos);
            await unitofwork.SaveAsync();
            return NoContent();
        }
    }

