﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pc3.Models;

namespace pc3.Migrations
{
    [DbContext(typeof(PruebaContext))]
    [Migration("20211012233759_inicial")]
    partial class inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("pc3.Models.Prueba", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Lugar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<float>("Precio")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Pruebas");
                });
#pragma warning restore 612, 618
        }
    }
}
