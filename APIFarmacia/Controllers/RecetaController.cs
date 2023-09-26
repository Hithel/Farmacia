

using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIFarmacia.Controllers;
    public class RecetaController : ApiBaseController
    {
        private readonly IUnitOfWork unitofwork;
        private readonly IMapper mapper;

        public RecetaController(IUnitOfWork unitofwork, IMapper mapper)
        {
            this.unitofwork = unitofwork;
            this.mapper = mapper;
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<IEnumerable<RecetaDto>>> Get()
        {
            var Recetas = await unitofwork.Recetas.GetAllAsync();
            return mapper.Map<List<RecetaDto>>(Recetas);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<RecetaDto>> Get(int id)
        {
            var Recetas = await unitofwork.Recetas.GetByIdAsync(id);
            if (Recetas == null){
                return NotFound();
            }
            return this.mapper.Map<RecetaDto>(Recetas);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<Receta>> Post(RecetaDto RecetaDto)
        {
            var Recetas = this.mapper.Map<Receta>(RecetaDto);
            this.unitofwork.Recetas.Add(Recetas);
            await unitofwork.SaveAsync();
            if(Recetas == null)
            {
                return BadRequest();
            }
            Recetas.Id = Recetas.Id;
            return CreatedAtAction(nameof(Post), new {id = Recetas.Id}, Recetas);
        }
    }
