
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
            CreateMap<TipoContacto, TipoContactoDto>().ReverseMap();
            CreateMap<TipoDocumento, TipoContactoDto>().ReverseMap();
            CreateMap<TipoPersona, TipoPersonaDto>().ReverseMap();
            CreateMap<MedicamentoComprado, MedicamentoCompradoDto>().ReverseMap();
            CreateMap<Medicamento, MedicamentoDto>().ReverseMap();
            CreateMap<MedicamentoVendido, MedicamentoVendidoDto>().ReverseMap();
            CreateMap<Pais, PaisDto>().ReverseMap();
            CreateMap<PersonaContacto, PersonaContactoDto>().ReverseMap();
            CreateMap<Persona, PersonaDto>().ReverseMap();
            CreateMap<Rol, RolDto>().ReverseMap();




            // CreateMap<Departamento, DepartamentoDto>().ReverseMap();

            // CreateMap<Pais,PaisxDepaDto>().ReverseMap();
        }
    }