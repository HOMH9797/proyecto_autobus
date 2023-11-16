﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api_web_servicio_bus.DAL;

#nullable disable

namespace api_web_servicio_bus.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20231116164219_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Direccion", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("id_cliente")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("address", "Availability", "id_cliente")
                        .IsUnique();

                    b.ToTable("Direcciones");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Reserva", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("cancel")
                        .HasColumnType("bit");

                    b.Property<string>("city_from")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("city_to")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("id_cliente")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("number_ticket")
                        .HasColumnType("int");

                    b.Property<bool>("pago_total")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("number_ticket", "id_cliente")
                        .IsUnique();

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Telefono", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("id_cliente")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("kind_phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("phone_number", "id_cliente")
                        .IsUnique();

                    b.ToTable("Telefonos");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Usuario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("id_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Direccion", b =>
                {
                    b.HasOne("api_web_servicio_bus.DAL.Entities.Usuario", null)
                        .WithMany("address")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Reserva", b =>
                {
                    b.HasOne("api_web_servicio_bus.DAL.Entities.Usuario", null)
                        .WithMany("reservation")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Telefono", b =>
                {
                    b.HasOne("api_web_servicio_bus.DAL.Entities.Usuario", null)
                        .WithMany("phone")
                        .HasForeignKey("UsuarioId");
                });

            modelBuilder.Entity("api_web_servicio_bus.DAL.Entities.Usuario", b =>
                {
                    b.Navigation("address");

                    b.Navigation("phone");

                    b.Navigation("reservation");
                });
#pragma warning restore 612, 618
        }
    }
}
