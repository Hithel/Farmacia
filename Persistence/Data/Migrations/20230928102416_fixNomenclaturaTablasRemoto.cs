using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Data.Migrations
{
    /// <inheritdoc />
    public partial class fixNomenclaturaTablasRemoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "cargos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cargo = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cargos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "estados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estados", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "marcas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_marcas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "paises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(120)", maxLength: 120, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedores", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tiposContactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposContactos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tiposDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposDocumentos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "tiposPersonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tiposPersonas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPaisFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_departamentos_paises_IdPaisFk",
                        column: x => x.IdPaisFk,
                        principalTable: "paises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedoresContactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Contacto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdProveedorFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoContactoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedoresContactos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proveedoresContactos_proveedores_IdProveedorFk",
                        column: x => x.IdProveedorFk,
                        principalTable: "proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedoresContactos_tiposContactos_IdTipoContactoFk",
                        column: x => x.IdTipoContactoFk,
                        principalTable: "tiposContactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    FechaRegistro = table.Column<DateTime>(type: "DateTime", nullable: false),
                    IdTipoDocumentoFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdCargoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personas_cargos_IdCargoFk",
                        column: x => x.IdCargoFk,
                        principalTable: "cargos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personas_tiposDocumentos_IdTipoDocumentoFk",
                        column: x => x.IdTipoDocumentoFk,
                        principalTable: "tiposDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personas_tiposPersonas_IdTipoPersonaFk",
                        column: x => x.IdTipoPersonaFk,
                        principalTable: "tiposPersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ciudades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdDepartamentoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ciudades_departamentos_IdDepartamentoFk",
                        column: x => x.IdDepartamentoFk,
                        principalTable: "departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "comprasProveedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FechaCompra = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdProveedorFk = table.Column<int>(type: "int", nullable: false),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_comprasProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_comprasProveedores_personas_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_comprasProveedores_proveedores_IdProveedorFk",
                        column: x => x.IdProveedorFk,
                        principalTable: "proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    total = table.Column<decimal>(type: "decimal(10,10)", nullable: false),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdDoctorFk = table.Column<int>(type: "int", nullable: false),
                    PersonaDoctorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_facturas_personas_IdDoctorFk",
                        column: x => x.IdDoctorFk,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_facturas_personas_PersonaDoctorId",
                        column: x => x.PersonaDoctorId,
                        principalTable: "personas",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "personasContactos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Contacto = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdTipoContactoFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personasContactos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personasContactos_personas_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personasContactos_tiposContactos_IdTipoContactoFk",
                        column: x => x.IdTipoContactoFk,
                        principalTable: "tiposContactos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "recetas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdDoctorFK = table.Column<int>(type: "int", nullable: false),
                    IdPacienteFK = table.Column<int>(type: "int", nullable: false),
                    FechaCrecion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    FechaExpiracion = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recetas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_recetas_personas_IdDoctorFK",
                        column: x => x.IdDoctorFK,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_recetas_personas_IdPacienteFK",
                        column: x => x.IdPacienteFK,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdRol = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_personas_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_users_roles_IdRol",
                        column: x => x.IdRol,
                        principalTable: "roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "personasDirecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdPersonaFk = table.Column<int>(type: "int", nullable: false),
                    IdCiudadFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personasDirecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personasDirecciones_ciudades_IdCiudadFk",
                        column: x => x.IdCiudadFk,
                        principalTable: "ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_personasDirecciones_personas_IdPersonaFk",
                        column: x => x.IdPersonaFk,
                        principalTable: "personas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "proveedoresDirecciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdCiudadFk = table.Column<int>(type: "int", nullable: false),
                    IdProveedorFk = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proveedoresDirecciones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_proveedoresDirecciones_ciudades_IdCiudadFk",
                        column: x => x.IdCiudadFk,
                        principalTable: "ciudades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_proveedoresDirecciones_proveedores_IdProveedorFk",
                        column: x => x.IdProveedorFk,
                        principalTable: "proveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    nombre = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    precio = table.Column<decimal>(type: "decimal(10,10)", nullable: false),
                    stock = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    fechavencimiento = table.Column<DateTime>(type: "datetime", nullable: false),
                    IdEstadoFK = table.Column<int>(type: "int", nullable: false),
                    EstadoReceta = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IdCategoriaFK = table.Column<int>(type: "int", nullable: false),
                    Presentacion = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    IdMarcaFk = table.Column<int>(type: "int", nullable: false),
                    MedicamentoCompradoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamentos_categorias_IdCategoriaFK",
                        column: x => x.IdCategoriaFK,
                        principalTable: "categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamentos_estados_IdEstadoFK",
                        column: x => x.IdEstadoFK,
                        principalTable: "estados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamentos_marcas_IdMarcaFk",
                        column: x => x.IdMarcaFk,
                        principalTable: "marcas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamentosComprados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdCompraProveedorFk = table.Column<int>(type: "int", nullable: false),
                    IdMedicamentoFk = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", maxLength: 6, nullable: false),
                    PrecioCompra = table.Column<decimal>(type: "decimal(10,10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamentosComprados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_medicamentosComprados_comprasProveedores_IdCompraProveedorFk",
                        column: x => x.IdCompraProveedorFk,
                        principalTable: "comprasProveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamentosComprados_medicamentos_IdMedicamentoFk",
                        column: x => x.IdMedicamentoFk,
                        principalTable: "medicamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "medicamentosVendidos",
                columns: table => new
                {
                    IdMedicamentoFk = table.Column<int>(type: "int", nullable: false),
                    IdRecetaFk = table.Column<int>(type: "int", nullable: false),
                    IdFacturaFK = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medicamentosVendidos", x => new { x.IdMedicamentoFk, x.IdRecetaFk });
                    table.ForeignKey(
                        name: "FK_medicamentosVendidos_facturas_IdFacturaFK",
                        column: x => x.IdFacturaFK,
                        principalTable: "facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamentosVendidos_medicamentos_IdMedicamentoFk",
                        column: x => x.IdMedicamentoFk,
                        principalTable: "medicamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_medicamentosVendidos_recetas_IdRecetaFk",
                        column: x => x.IdRecetaFk,
                        principalTable: "recetas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ciudades_IdDepartamentoFk",
                table: "ciudades",
                column: "IdDepartamentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_comprasProveedores_IdPersonaFk",
                table: "comprasProveedores",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_comprasProveedores_IdProveedorFk",
                table: "comprasProveedores",
                column: "IdProveedorFk");

            migrationBuilder.CreateIndex(
                name: "IX_departamentos_IdPaisFk",
                table: "departamentos",
                column: "IdPaisFk");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_IdDoctorFk",
                table: "facturas",
                column: "IdDoctorFk");

            migrationBuilder.CreateIndex(
                name: "IX_facturas_PersonaDoctorId",
                table: "facturas",
                column: "PersonaDoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentos_IdCategoriaFK",
                table: "medicamentos",
                column: "IdCategoriaFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentos_IdEstadoFK",
                table: "medicamentos",
                column: "IdEstadoFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentos_IdMarcaFk",
                table: "medicamentos",
                column: "IdMarcaFk");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentos_MedicamentoCompradoId",
                table: "medicamentos",
                column: "MedicamentoCompradoId");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentosComprados_IdCompraProveedorFk",
                table: "medicamentosComprados",
                column: "IdCompraProveedorFk");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentosComprados_IdMedicamentoFk",
                table: "medicamentosComprados",
                column: "IdMedicamentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentosVendidos_IdFacturaFK",
                table: "medicamentosVendidos",
                column: "IdFacturaFK");

            migrationBuilder.CreateIndex(
                name: "IX_medicamentosVendidos_IdRecetaFk",
                table: "medicamentosVendidos",
                column: "IdRecetaFk");

            migrationBuilder.CreateIndex(
                name: "IX_personas_IdCargoFk",
                table: "personas",
                column: "IdCargoFk");

            migrationBuilder.CreateIndex(
                name: "IX_personas_IdTipoDocumentoFk",
                table: "personas",
                column: "IdTipoDocumentoFk");

            migrationBuilder.CreateIndex(
                name: "IX_personas_IdTipoPersonaFk",
                table: "personas",
                column: "IdTipoPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_personasContactos_IdPersonaFk",
                table: "personasContactos",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_personasContactos_IdTipoContactoFk",
                table: "personasContactos",
                column: "IdTipoContactoFk");

            migrationBuilder.CreateIndex(
                name: "IX_personasDirecciones_IdCiudadFk",
                table: "personasDirecciones",
                column: "IdCiudadFk");

            migrationBuilder.CreateIndex(
                name: "IX_personasDirecciones_IdPersonaFk",
                table: "personasDirecciones",
                column: "IdPersonaFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedoresContactos_IdProveedorFk",
                table: "proveedoresContactos",
                column: "IdProveedorFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedoresContactos_IdTipoContactoFk",
                table: "proveedoresContactos",
                column: "IdTipoContactoFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedoresDirecciones_IdCiudadFk",
                table: "proveedoresDirecciones",
                column: "IdCiudadFk");

            migrationBuilder.CreateIndex(
                name: "IX_proveedoresDirecciones_IdProveedorFk",
                table: "proveedoresDirecciones",
                column: "IdProveedorFk");

            migrationBuilder.CreateIndex(
                name: "IX_recetas_IdDoctorFK",
                table: "recetas",
                column: "IdDoctorFK");

            migrationBuilder.CreateIndex(
                name: "IX_recetas_IdPacienteFK",
                table: "recetas",
                column: "IdPacienteFK");

            migrationBuilder.CreateIndex(
                name: "IX_users_IdPersonaFk",
                table: "users",
                column: "IdPersonaFk",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_users_IdRol",
                table: "users",
                column: "IdRol");

            migrationBuilder.AddForeignKey(
                name: "FK_medicamentos_medicamentosComprados_MedicamentoCompradoId",
                table: "medicamentos",
                column: "MedicamentoCompradoId",
                principalTable: "medicamentosComprados",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_comprasProveedores_personas_IdPersonaFk",
                table: "comprasProveedores");

            migrationBuilder.DropForeignKey(
                name: "FK_comprasProveedores_proveedores_IdProveedorFk",
                table: "comprasProveedores");

            migrationBuilder.DropForeignKey(
                name: "FK_medicamentos_categorias_IdCategoriaFK",
                table: "medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_medicamentos_estados_IdEstadoFK",
                table: "medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_medicamentos_marcas_IdMarcaFk",
                table: "medicamentos");

            migrationBuilder.DropForeignKey(
                name: "FK_medicamentos_medicamentosComprados_MedicamentoCompradoId",
                table: "medicamentos");

            migrationBuilder.DropTable(
                name: "medicamentosVendidos");

            migrationBuilder.DropTable(
                name: "personasContactos");

            migrationBuilder.DropTable(
                name: "personasDirecciones");

            migrationBuilder.DropTable(
                name: "proveedoresContactos");

            migrationBuilder.DropTable(
                name: "proveedoresDirecciones");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "facturas");

            migrationBuilder.DropTable(
                name: "recetas");

            migrationBuilder.DropTable(
                name: "tiposContactos");

            migrationBuilder.DropTable(
                name: "ciudades");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "paises");

            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "cargos");

            migrationBuilder.DropTable(
                name: "tiposDocumentos");

            migrationBuilder.DropTable(
                name: "tiposPersonas");

            migrationBuilder.DropTable(
                name: "proveedores");

            migrationBuilder.DropTable(
                name: "categorias");

            migrationBuilder.DropTable(
                name: "estados");

            migrationBuilder.DropTable(
                name: "marcas");

            migrationBuilder.DropTable(
                name: "medicamentosComprados");

            migrationBuilder.DropTable(
                name: "comprasProveedores");

            migrationBuilder.DropTable(
                name: "medicamentos");
        }
    }
}
