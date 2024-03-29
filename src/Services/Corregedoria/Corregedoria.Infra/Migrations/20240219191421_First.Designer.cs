﻿// <auto-generated />
using System;
using Corregedoria.Infra.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Corregedoria.Infra.Migrations
{
    [DbContext(typeof(CorregedoriaContext))]
    [Migration("20240219191421_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Corregedoria.Domain.Entidades.Instauracao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<string>("AtoNormativo")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("AtoNormativo");

                    b.Property<string>("AtoNormativoDecisao")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("AtoNormativoDecisao");

                    b.Property<string>("CNPJCPF")
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("DataPublicacao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DataPublicacao");

                    b.Property<DateTime?>("DataPublicacaoDecisao")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("DataPublicacaoDecisao");

                    b.Property<string>("Decisao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("InfoAdd")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("InfoAdd");

                    b.Property<int?>("NumeroDIOE")
                        .HasColumnType("int")
                        .HasColumnName("NumeroDIOE");

                    b.Property<int?>("NumeroDIOEDecisao")
                        .HasColumnType("int")
                        .HasColumnName("NumeroDIOEDecisao");

                    b.Property<string>("Objeto")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Orgao")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Procedimento")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Protocolo")
                        .HasColumnType("varchar(100)")
                        .HasColumnName("Protocolo");

                    b.Property<string>("RG")
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Instauracoes");
                });
#pragma warning restore 612, 618
        }
    }
}
