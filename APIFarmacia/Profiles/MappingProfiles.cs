
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<ProveedorDireccion, ProveedorDireccionDto>().ReverseMap();
            CreateMap<Proveedor, ProveedorDto>().ReverseMap();
            CreateMap<Receta, RecetaDto>().ReverseMap();


            // CreateMap<Departamento, DepartamentoDto>().ReverseMap();

            // CreateMap<Pais,PaisxDepaDto>().ReverseMap();
        }
    }