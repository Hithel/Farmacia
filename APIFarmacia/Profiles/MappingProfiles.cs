
using APIFarmacia.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Cargo, CargoDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Ciudad, CiudadDto>().ReverseMap();
            CreateMap<CompraProveedor, CompraProveedorDto>().ReverseMap();
            CreateMap<Departamento, DepartamentoDto>().ReverseMap();
            CreateMap<Estado, EstadoDto>().ReverseMap();
            CreateMap<Factura, FacturaDto>().ReverseMap();
            CreateMap<Marca, MarcaDto>().ReverseMap();
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
            
<<<<<<< HEAD





=======
>>>>>>> d68797e4d9c38bc48857ced52bb4b80d05490e20
            // CreateMap<Departamento, DepartamentoDto>().ReverseMap();

            // CreateMap<Pais,PaisxDepaDto>().ReverseMap();
        }
    }