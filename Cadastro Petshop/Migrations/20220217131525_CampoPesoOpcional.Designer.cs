﻿// <auto-generated />
using System;
using Cadastro_Petshop.Persistencia;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cadastro_Petshop.Migrations
{
    [DbContext(typeof(Cadastro_PetshopContext))]
    [Migration("20220217131525_CampoPesoOpcional")]
    partial class CampoPesoOpcional
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Cadastro_Petshop.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Castrado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Especie")
                        .HasColumnType("int");

                    b.Property<int?>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<double>("Peso")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("TB_Animal");
                });
#pragma warning restore 612, 618
        }
    }
}
