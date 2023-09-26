
using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        
        private readonly FarmaciaContext _context;

        private CargoRepository _cargos;
        private CategoriaRepository _categorias;
        private CiudadRepository _ciudades;         
        private CompraProveedorRepository _compraProveedor;
        private DepartamentoRepository _departamentos;
        private EstadoRepository _estados;
        private FacturaRepository _facturas;
        private MarcaRepository _marcas;
        private MedicamentoRepository _medicamentos;
        private MedicamentoCompradoRepository _medicamentoComprados;
        private PaisRepository _paises;
        private PersonaRepository _personas;
        private PersonaContactoRepository _personaContactos;
        private PersonaDireccionRepository _personaDirecciones;
        private ProveedorRepository _proveedores;
        private ProveedorContactoRepository _proveedorContactos;
        private ProveedorDireccionRepository _proveedorDirecciones;
        private RecetaRepository _recetas;
        private RolRepository _roles;
        private TipoContactoRepository _tipoContactos;
        private TipoDocumentoRepository _tipoDocumentos;
        private TipoPersonaRepository _tipoPersonas;
        private UserRepository _users;

        
        public ICargo Cargos
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepository(_context);
                }
                return _cargos;
            }
        }

        public ICategoria Categorias
        {
            get
            {
                if (_categorias == null)
                {
                    _categorias = new CategoriaRepository(_context);
                }
                return _categorias;
            }
        }

        public ICiudad Ciudades
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepository(_context);
                }
                return _ciudades;
            }
        }

        public ICompraProveedor CompraProveedor
        {
            get
            {
                if (_compraProveedor == null)
                {
                    _compraProveedor = new CompraProveedorRepository(_context);
                }
                return _compraProveedor;
            }
        }

        public IDepartamento Departamentos
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepository(_context);
                }
                return _departamentos;
            }
        }

        public IEstado Estados
        {
            get
            {
                if (_estados == null)
                {
                    _estados = new EstadoRepository(_context);
                }
                return _estados;
            }
        }

        public IFactura Facturas
        {
            get
            {
                if (_facturas == null)
                {
                    _facturas = new FacturaRepository(_context);
                }
                return _facturas;
            }
        }

        public IMarca Marcas
        {
            get
            {
                if (_marcas == null)
                {
                    _marcas = new MarcaRepository(_context);
                }
                return _marcas;
            }
        }

        public IMedicamento Medicamentos
        {
            get
            {
                if (_medicamentos == null)
                {
                    _medicamentos = new MedicamentoRepository(_context);
                }
                return _medicamentos;
            }
        }

        public IMedicamentoComprado MedicamentoComprados
        {
            get
            {
                if (_medicamentoComprados == null)
                {
                    _medicamentoComprados = new MedicamentoCompradoRepository(_context);
                }
                return _medicamentoComprados;
            }
        }

        public IPais Paises
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepository(_context);
                }
                return _paises;
            }
        }

        public IPersona Personas
        {
            get
            {
                if (_personas == null)
                {
                    _personas = new PersonaRepository(_context);
                }
                return _personas;
            }
        }

        public IPersonaContacto PersonaContactos
        {
            get
            {
                if (_personaContactos == null)
                {
                    _personaContactos = new PersonaContactoRepository(_context);
                }
                return _personaContactos;
            }
        }

        public IPersonaDireccion PersonaDirecciones
        {
            get
            {
                if (_personaDirecciones == null)
                {
                    _personaDirecciones = new PersonaDireccionRepository(_context);
                }
                return _personaDirecciones;
            }
        }

        public IProveedor Proveedores
        {
            get
            {
                if (_proveedores == null)
                {
                    _proveedores = new ProveedorRepository(_context);
                }
                return _proveedores;
            }
        }

        public IProveedorContacto ProveedorContactos
        {
            get
            {
                if (_proveedorContactos == null)
                {
                    _proveedorContactos = new ProveedorContactoRepository(_context);
                }
                return _proveedorContactos;
            }
        }

        public IProveedorDireccion ProveedorDirecciones
        {
            get
            {
                if (_proveedorDirecciones == null)
                {
                    _proveedorDirecciones = new ProveedorDireccionRepository(_context);
                }
                return _proveedorDirecciones;
            }
        }

        public IReceta Recetas
        {
            get
            {
                if (_recetas == null)
                {
                    _recetas = new RecetaRepository(_context);
                }
                return _recetas;
            }
        }

        public IRol Roles
        {
            get
            {
                if (_roles == null)
                {
                    _roles = new RolRepository(_context);
                }
                return _roles;
            }
        }

        public ITipoContacto TipoContactos
        {
            get
            {
                if (_tipoContactos == null)
                {
                    _tipoContactos = new TipoContactoRepository(_context);
                }
                return _tipoContactos;
            }
        }

        public ITipoDocumento TipoDocumentos
        {
            get
            {
                if (_tipoDocumentos == null)
                {
                    _tipoDocumentos = new TipoDocumentoRepository(_context);
                }
                return _tipoDocumentos;
            }
        }

        public ITipoPersona TipoPersonas
        {
            get
            {
                if (_tipoPersonas == null)
                {
                    _tipoPersonas = new TipoPersonaRepository(_context);
                }
                return _tipoPersonas;
            }
        }

        public IUser Users
        {
            get
            {
                if (_users == null)
                {
                    _users = new UserRepository(_context);
                }
                return _users;
            }
        }




        public void Dispose()
        {
            _context.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }





    }
}