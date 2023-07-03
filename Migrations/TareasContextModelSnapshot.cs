﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectEF;

#nullable disable

namespace ProjectEF.Migrations
{
    [DbContext(typeof(TareasContext))]
    partial class TareasContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjectEF.Models.Categoria", b =>
                {
                    b.Property<Guid>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("Peso")
                        .HasColumnType("int");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categoria", (string)null);

                    b.HasData(
                        new
                        {
                            CategoriaId = new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7be6"),
                            Nombre = "Actividades pendientes",
                            Peso = 20
                        },
                        new
                        {
                            CategoriaId = new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b01"),
                            Nombre = "Actividades personales",
                            Peso = 21
                        });
                });

            modelBuilder.Entity("ProjectEF.Models.Tarea", b =>
                {
                    b.Property<Guid>("TareaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoriaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("PrioridadTarea")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("TareaId");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Tarea", (string)null);

                    b.HasData(
                        new
                        {
                            TareaId = new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b10"),
                            CategoriaId = new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7be6"),
                            FechaCreacion = new DateTime(2023, 6, 30, 15, 30, 1, 47, DateTimeKind.Local).AddTicks(9495),
                            PrioridadTarea = 1,
                            Titulo = "Servicios publicos"
                        },
                        new
                        {
                            TareaId = new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b22"),
                            CategoriaId = new Guid("d4cb25da-0a5e-4289-ad86-5204a99f7b01"),
                            FechaCreacion = new DateTime(2023, 6, 30, 15, 30, 1, 47, DateTimeKind.Local).AddTicks(9515),
                            PrioridadTarea = 0,
                            Titulo = "Peliculas en Netflix"
                        });
                });

            modelBuilder.Entity("ProjectEF.Models.Tarea", b =>
                {
                    b.HasOne("ProjectEF.Models.Categoria", "Categoria")
                        .WithMany("Tareas")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("ProjectEF.Models.Categoria", b =>
                {
                    b.Navigation("Tareas");
                });
#pragma warning restore 612, 618
        }
    }
}
