﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Data.Migrations
{
    [DbContext(typeof(FarmaciaContext))]
    partial class FarmaciaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Domain.Entities.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("cargo");

                    b.HasKey("Id");

                    b.ToTable("cargo", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("categoria", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdDepartamentoFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.HasIndex("IdDepartamentoFk");

                    b.ToTable("ciudad", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.CompraProveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaCompra")
                        .HasColumnType("datetime")
                        .HasColumnName("FechaCompra");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdProveedorFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdProveedorFk");

                    b.ToTable("compraproveedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPaisFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("IdPaisFk");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("Estado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Factura", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime")
                        .HasColumnName("fecha");

                    b.Property<int>("IdDoctorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int?>("PersonaDoctorId")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,10)")
                        .HasColumnName("total");

                    b.HasKey("Id");

                    b.HasIndex("IdDoctorFk");

                    b.HasIndex("PersonaDoctorId");

                    b.ToTable("Factura", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("marca", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Medicamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("EstadoReceta")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaVencimiento")
                        .HasColumnType("datetime")
                        .HasColumnName("fechavencimiento");

                    b.Property<int>("IdCategoriaFK")
                        .HasColumnType("int");

                    b.Property<int>("IdEstadoFK")
                        .HasColumnType("int");

                    b.Property<int>("IdMarcaFk")
                        .HasColumnType("int");

                    b.Property<int?>("MedicamentoCompradoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10,10)")
                        .HasColumnName("precio");

                    b.Property<string>("Presentacion")
                        .HasColumnType("longtext");

                    b.Property<int>("Stock")
                        .HasMaxLength(6)
                        .HasColumnType("int")
                        .HasColumnName("stock");

                    b.HasKey("Id");

                    b.HasIndex("IdCategoriaFK");

                    b.HasIndex("IdEstadoFK");

                    b.HasIndex("IdMarcaFk");

                    b.HasIndex("MedicamentoCompradoId");

                    b.ToTable("medicamento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoComprado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasMaxLength(6)
                        .HasColumnType("int")
                        .HasColumnName("Cantidad");

                    b.Property<int>("IdCompraProveedorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicamentoFk")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioCompra")
                        .HasColumnType("decimal(10,10)")
                        .HasColumnName("PrecioCompra");

                    b.HasKey("Id");

                    b.HasIndex("IdCompraProveedorFk");

                    b.HasIndex("IdMedicamentoFk");

                    b.ToTable("MedicamentoComprado", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoReceta", b =>
                {
                    b.Property<int>("IdMedicamentoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRecetaFk")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdMedicamentoFk", "IdRecetaFk");

                    b.HasIndex("IdRecetaFk");

                    b.ToTable("MedicamentoReceta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoVendido", b =>
                {
                    b.Property<int>("IdMedicamentoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaFK")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IdMedicamentoFk", "IdFacturaFK");

                    b.HasIndex("IdFacturaFK");

                    b.ToTable("MedicamentoVendido", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("varchar(120)")
                        .HasColumnName("nombre");

                    b.HasKey("Id");

                    b.ToTable("pais", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("DateTime")
                        .HasColumnName("FechaRegistro");

                    b.Property<int>("IdCargoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoDocumentoFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoPersonaFk")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.HasIndex("IdCargoFk");

                    b.HasIndex("IdTipoDocumentoFk");

                    b.HasIndex("IdTipoPersonaFk");

                    b.ToTable("Persona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.PersonaContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Contacto");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoContactoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk");

                    b.HasIndex("IdTipoContactoFk");

                    b.ToTable("PersonaContacto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.PersonaDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descripcion");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdPersonaFk");

                    b.ToTable("PersonaDireccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Nombre");

                    b.HasKey("Id");

                    b.ToTable("Proveedor", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProveedorContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Contacto");

                    b.Property<int>("IdProveedorFk")
                        .HasColumnType("int");

                    b.Property<int>("IdTipoContactoFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdProveedorFk");

                    b.HasIndex("IdTipoContactoFk");

                    b.ToTable("ProveedorContacto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProveedorDireccion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descripcion");

                    b.Property<int>("IdCiudadFk")
                        .HasColumnType("int");

                    b.Property<int>("IdProveedorFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCiudadFk");

                    b.HasIndex("IdProveedorFk");

                    b.ToTable("ProveedorDireccion", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Receta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descripcion");

                    b.Property<DateTime>("FechaCrecion")
                        .HasColumnType("DateTime")
                        .HasColumnName("FechaCrecion");

                    b.Property<DateTime>("FechaExpiracion")
                        .HasColumnType("DateTime")
                        .HasColumnName("FechaExpiracion");

                    b.Property<int>("IdDoctorFK")
                        .HasColumnType("int");

                    b.Property<int>("IdFacturaFK")
                        .HasColumnType("int");

                    b.Property<int>("IdMedicamentoRecetaFK")
                        .HasColumnType("int");

                    b.Property<int>("IdPacienteFK")
                        .HasColumnType("int");

                    b.Property<int?>("MedicamentoRecetaIdMedicamentoFk")
                        .HasColumnType("int");

                    b.Property<int?>("MedicamentoRecetaIdRecetaFk")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDoctorFK");

                    b.HasIndex("IdFacturaFK");

                    b.HasIndex("IdPacienteFK");

                    b.HasIndex("MedicamentoRecetaIdMedicamentoFk", "MedicamentoRecetaIdRecetaFk");

                    b.ToTable("Receta", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TipoContacto", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TipoDocumento", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Descripcion")
                        .HasMaxLength(50)
                        .HasColumnType("int")
                        .HasColumnName("Descripcion");

                    b.HasKey("Id");

                    b.ToTable("TipoPersona", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("IdPersonaFk")
                        .HasColumnType("int");

                    b.Property<int>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar")
                        .HasColumnName("password");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("IdPersonaFk")
                        .IsUnique();

                    b.HasIndex("IdRol");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.HasOne("Domain.Entities.Departamento", "Departamento")
                        .WithMany("Ciudades")
                        .HasForeignKey("IdDepartamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("Domain.Entities.CompraProveedor", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithMany("CompraProveedores")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("CompraProveedores")
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.HasOne("Domain.Entities.Pais", "Pais")
                        .WithMany("Departamentos")
                        .HasForeignKey("IdPaisFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pais");
                });

            modelBuilder.Entity("Domain.Entities.Factura", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithMany("Facturas")
                        .HasForeignKey("IdDoctorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "PersonaDoctor")
                        .WithMany()
                        .HasForeignKey("PersonaDoctorId");

                    b.Navigation("Persona");

                    b.Navigation("PersonaDoctor");
                });

            modelBuilder.Entity("Domain.Entities.Medicamento", b =>
                {
                    b.HasOne("Domain.Entities.Categoria", "Categoria")
                        .WithMany("Medicamentos")
                        .HasForeignKey("IdCategoriaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Estado", "Estado")
                        .WithMany("Medicamentos")
                        .HasForeignKey("IdEstadoFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Marca", "Marca")
                        .WithMany("Medicamentos")
                        .HasForeignKey("IdMarcaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.MedicamentoComprado", null)
                        .WithMany("Medicamentos")
                        .HasForeignKey("MedicamentoCompradoId");

                    b.Navigation("Categoria");

                    b.Navigation("Estado");

                    b.Navigation("Marca");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoComprado", b =>
                {
                    b.HasOne("Domain.Entities.CompraProveedor", "Compra")
                        .WithMany("MedicamentoComprados")
                        .HasForeignKey("IdCompraProveedorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Medicamento", "Medicamento")
                        .WithMany("MedicamentoComprados")
                        .HasForeignKey("IdMedicamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Medicamento");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoReceta", b =>
                {
                    b.HasOne("Domain.Entities.Medicamento", "Medicamento")
                        .WithMany("MedicamentoRecetas")
                        .HasForeignKey("IdMedicamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Receta", "Receta")
                        .WithMany("MedicamentoRecetas")
                        .HasForeignKey("IdRecetaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Medicamento");

                    b.Navigation("Receta");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoVendido", b =>
                {
                    b.HasOne("Domain.Entities.Factura", "Factura")
                        .WithMany("MedicamentoVendidos")
                        .HasForeignKey("IdFacturaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Medicamento", "Medicamento")
                        .WithMany("MedicamentoVendidos")
                        .HasForeignKey("IdMedicamentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Factura");

                    b.Navigation("Medicamento");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.HasOne("Domain.Entities.Cargo", "Cargo")
                        .WithMany("Personas")
                        .HasForeignKey("IdCargoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoDocumento", "TipoDocumento")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoDocumentoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoPersona", "TipoPersona")
                        .WithMany("Personas")
                        .HasForeignKey("IdTipoPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cargo");

                    b.Navigation("TipoDocumento");

                    b.Navigation("TipoPersona");
                });

            modelBuilder.Entity("Domain.Entities.PersonaContacto", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithMany("PersonaContactos")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoContacto", "TipoContacto")
                        .WithMany("PersonaContactos")
                        .HasForeignKey("IdTipoContactoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("TipoContacto");
                });

            modelBuilder.Entity("Domain.Entities.PersonaDireccion", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudad")
                        .WithMany("PersonaDirecciones")
                        .HasForeignKey("IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithMany("PersonaDirecciones")
                        .HasForeignKey("IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Persona");
                });

            modelBuilder.Entity("Domain.Entities.ProveedorContacto", b =>
                {
                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("ProveedorContactos")
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.TipoContacto", "TipoContacto")
                        .WithMany("ProveedorContactos")
                        .HasForeignKey("IdTipoContactoFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proveedor");

                    b.Navigation("TipoContacto");
                });

            modelBuilder.Entity("Domain.Entities.ProveedorDireccion", b =>
                {
                    b.HasOne("Domain.Entities.Ciudad", "Ciudad")
                        .WithMany("ProveedorDirecciones")
                        .HasForeignKey("IdCiudadFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("ProveedorDirecciones")
                        .HasForeignKey("IdProveedorFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ciudad");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Domain.Entities.Receta", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Doctor")
                        .WithMany("RecetasDoc")
                        .HasForeignKey("IdDoctorFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Factura", "Factura")
                        .WithMany("Recetas")
                        .HasForeignKey("IdFacturaFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Persona", "Paciente")
                        .WithMany("RecetasPac")
                        .HasForeignKey("IdPacienteFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.MedicamentoReceta", "MedicamentoReceta")
                        .WithMany()
                        .HasForeignKey("MedicamentoRecetaIdMedicamentoFk", "MedicamentoRecetaIdRecetaFk");

                    b.Navigation("Doctor");

                    b.Navigation("Factura");

                    b.Navigation("MedicamentoReceta");

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.HasOne("Domain.Entities.Persona", "Persona")
                        .WithOne("User")
                        .HasForeignKey("Domain.Entities.User", "IdPersonaFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Rol", "Rol")
                        .WithMany("Users")
                        .HasForeignKey("IdRol")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Persona");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Domain.Entities.Cargo", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.Categoria", b =>
                {
                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("Domain.Entities.Ciudad", b =>
                {
                    b.Navigation("PersonaDirecciones");

                    b.Navigation("ProveedorDirecciones");
                });

            modelBuilder.Entity("Domain.Entities.CompraProveedor", b =>
                {
                    b.Navigation("MedicamentoComprados");
                });

            modelBuilder.Entity("Domain.Entities.Departamento", b =>
                {
                    b.Navigation("Ciudades");
                });

            modelBuilder.Entity("Domain.Entities.Estado", b =>
                {
                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("Domain.Entities.Factura", b =>
                {
                    b.Navigation("MedicamentoVendidos");

                    b.Navigation("Recetas");
                });

            modelBuilder.Entity("Domain.Entities.Marca", b =>
                {
                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("Domain.Entities.Medicamento", b =>
                {
                    b.Navigation("MedicamentoComprados");

                    b.Navigation("MedicamentoRecetas");

                    b.Navigation("MedicamentoVendidos");
                });

            modelBuilder.Entity("Domain.Entities.MedicamentoComprado", b =>
                {
                    b.Navigation("Medicamentos");
                });

            modelBuilder.Entity("Domain.Entities.Pais", b =>
                {
                    b.Navigation("Departamentos");
                });

            modelBuilder.Entity("Domain.Entities.Persona", b =>
                {
                    b.Navigation("CompraProveedores");

                    b.Navigation("Facturas");

                    b.Navigation("PersonaContactos");

                    b.Navigation("PersonaDirecciones");

                    b.Navigation("RecetasDoc");

                    b.Navigation("RecetasPac");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("CompraProveedores");

                    b.Navigation("ProveedorContactos");

                    b.Navigation("ProveedorDirecciones");
                });

            modelBuilder.Entity("Domain.Entities.Receta", b =>
                {
                    b.Navigation("MedicamentoRecetas");
                });

            modelBuilder.Entity("Domain.Entities.Rol", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Domain.Entities.TipoContacto", b =>
                {
                    b.Navigation("PersonaContactos");

                    b.Navigation("ProveedorContactos");
                });

            modelBuilder.Entity("Domain.Entities.TipoDocumento", b =>
                {
                    b.Navigation("Personas");
                });

            modelBuilder.Entity("Domain.Entities.TipoPersona", b =>
                {
                    b.Navigation("Personas");
                });
#pragma warning restore 612, 618
        }
    }
}
