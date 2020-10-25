﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using poiesis_api;

namespace poiesis_api.Migrations
{
    [DbContext(typeof(PoiesisDBContext))]
    partial class PoiesisDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("poiesis_api.Texto", b =>
                {
                    b.Property<int>("idTexto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contenido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("genero")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("titulo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idTexto");

                    b.HasIndex("idUsuario");

                    b.ToTable("Textos");
                });

            modelBuilder.Entity("poiesis_api.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contrasenia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("eleccionDiaYHorario")
                        .HasColumnType("int");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experienciaDeEscritura")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("frecuenciaDeLectura")
                        .HasColumnType("int");

                    b.Property<int>("generoDeEscritura")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("poiesis_api.Texto", b =>
                {
                    b.HasOne("poiesis_api.Usuario", "Usuario")
                        .WithMany("Texto")
                        .HasForeignKey("idUsuario")
                        .HasConstraintName("FK_Texto_Usuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}