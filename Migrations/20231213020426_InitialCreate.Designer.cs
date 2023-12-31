﻿// <auto-generated />
using System;
using EventoApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EventoApi.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20231213020426_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EventoApi.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Artista")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Classe")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Local")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TB_EVENTOS");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artista = "NCT 127",
                            Classe = 1,
                            Data = new DateTime(2023, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Vibra",
                            Nome = "Neo City: The Link Tour"
                        },
                        new
                        {
                            Id = 2,
                            Artista = "NCT DREAM",
                            Classe = 1,
                            Data = new DateTime(2023, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Vibra",
                            Nome = "The Dream Show II: In A Dream"
                        },
                        new
                        {
                            Id = 3,
                            Artista = "ATEEZ",
                            Classe = 1,
                            Data = new DateTime(2023, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Allianz Parque",
                            Nome = "The Fellowship: Break the Wall Tour"
                        },
                        new
                        {
                            Id = 4,
                            Artista = "Bruno Mars, Post Malone...",
                            Classe = 2,
                            Data = new DateTime(2023, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Autódromo de Interlagos",
                            Nome = "THE TOWN"
                        },
                        new
                        {
                            Id = 5,
                            Artista = "aespa",
                            Classe = 1,
                            Data = new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Espaço Unimed",
                            Nome = "Synk: Hyper Line Tour"
                        },
                        new
                        {
                            Id = 6,
                            Artista = "Evanescence",
                            Classe = 1,
                            Data = new DateTime(2023, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Allianz Parque",
                            Nome = "South American Tour"
                        },
                        new
                        {
                            Id = 7,
                            Artista = "RBD",
                            Classe = 1,
                            Data = new DateTime(2023, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Allianz Parque",
                            Nome = "Soy Rebelde Tour"
                        },
                        new
                        {
                            Id = 8,
                            Artista = "Taylor Swift",
                            Classe = 1,
                            Data = new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Allianz Parque",
                            Nome = "The Eras Tour"
                        },
                        new
                        {
                            Id = 9,
                            Artista = "TWICE",
                            Classe = 1,
                            Data = new DateTime(2024, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Allianz Parque",
                            Nome = "Ready To Be"
                        },
                        new
                        {
                            Id = 10,
                            Artista = "IVE",
                            Classe = 1,
                            Data = new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Local = "São Paulo, Espaço Unimed",
                            Nome = "SHOW WHAT I HAVE"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
