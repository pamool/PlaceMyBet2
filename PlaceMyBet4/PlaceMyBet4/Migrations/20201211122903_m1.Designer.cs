﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PlaceMyBet4.Models;

namespace PlaceMyBet4.Migrations
{
    [DbContext(typeof(PlaceMyBetContext))]
    [Migration("20201211122903_m1")]
    partial class m1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("PlaceMyBet4.Models.Apuesta", b =>
                {
                    b.Property<int>("ApuestaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Cuota")
                        .HasColumnType("double");

                    b.Property<double>("DineroApuesta")
                        .HasColumnType("double");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("MercadoId")
                        .HasColumnType("int");

                    b.Property<double>("OverUnder")
                        .HasColumnType("double");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.Property<string>("tipoApuesta")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ApuestaId");

                    b.HasIndex("MercadoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Apuesta");

                    b.HasData(
                        new
                        {
                            ApuestaId = 12,
                            Cuota = 1.8999999999999999,
                            DineroApuesta = 20.0,
                            EventoId = 1,
                            Fecha = new DateTime(2020, 12, 11, 13, 29, 3, 32, DateTimeKind.Local).AddTicks(9514),
                            MercadoId = 1000,
                            OverUnder = 1.5,
                            UsuarioId = 1,
                            tipoApuesta = "over"
                        });
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Cuenta", b =>
                {
                    b.Property<int>("CuentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<double>("Saldo")
                        .HasColumnType("double");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("CuentaId");

                    b.HasIndex("UsuarioID")
                        .IsUnique();

                    b.ToTable("Cuenta");

                    b.HasData(
                        new
                        {
                            CuentaId = 100,
                            Nombre = "Santander",
                            Saldo = 123456789.0,
                            UsuarioID = 1
                        });
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("EquipoLocal")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("EquipoVisitante")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.HasKey("EventoId");

                    b.ToTable("Evento");

                    b.HasData(
                        new
                        {
                            EventoId = 1,
                            EquipoLocal = "Valencia",
                            EquipoVisitante = "Madrid",
                            Fecha = new DateTime(2020, 12, 11, 13, 29, 3, 25, DateTimeKind.Local).AddTicks(9696)
                        });
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Mercado", b =>
                {
                    b.Property<int>("MercadoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("CuotaOver")
                        .HasColumnType("double");

                    b.Property<double>("CuotaUnder")
                        .HasColumnType("double");

                    b.Property<double>("DineroOver")
                        .HasColumnType("double");

                    b.Property<double>("DineroUnder")
                        .HasColumnType("double");

                    b.Property<int>("EventoId")
                        .HasColumnType("int");

                    b.Property<double>("OverUnder")
                        .HasColumnType("double");

                    b.HasKey("MercadoId");

                    b.HasIndex("EventoId");

                    b.ToTable("Mercado");

                    b.HasData(
                        new
                        {
                            MercadoId = 1000,
                            CuotaOver = 1.8999999999999999,
                            CuotaUnder = 1.8999999999999999,
                            DineroOver = 50.0,
                            DineroUnder = 50.0,
                            EventoId = 1,
                            OverUnder = 1.5
                        });
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("edad")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            apellido = "Monterde",
                            edad = 20,
                            nombre = "Pau"
                        });
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Apuesta", b =>
                {
                    b.HasOne("PlaceMyBet4.Models.Mercado", "mercado")
                        .WithMany()
                        .HasForeignKey("MercadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PlaceMyBet4.Models.Usuario", "usuario")
                        .WithMany("Apuestas")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Cuenta", b =>
                {
                    b.HasOne("PlaceMyBet4.Models.Usuario", "usuario")
                        .WithOne("Cuenta")
                        .HasForeignKey("PlaceMyBet4.Models.Cuenta", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PlaceMyBet4.Models.Mercado", b =>
                {
                    b.HasOne("PlaceMyBet4.Models.Evento", "evento")
                        .WithMany()
                        .HasForeignKey("EventoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
