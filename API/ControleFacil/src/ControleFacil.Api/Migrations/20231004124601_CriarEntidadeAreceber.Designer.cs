﻿// <auto-generated />
using System;
using ControleFacil.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ControleFacil.Api.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20231004124601_CriarEntidadeAreceber")]
    partial class CriarEntidadeAreceber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ControleFacil.Api.Models.Apagar", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataInativacao")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataReferencia")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("timestamp");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<long>("IdNaturezaDeLancamento")
                        .HasColumnType("bigint");

                    b.Property<long>("IdUsuario")
                        .HasColumnType("bigint");

                    b.Property<string>("Observacao")
                        .HasColumnType("VARCHAR");

                    b.Property<double>("ValorOriginal")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorPago")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("IdNaturezaDeLancamento");

                    b.HasIndex("IdUsuario");

                    b.ToTable("apagar", (string)null);
                });

            modelBuilder.Entity("ControleFacil.Api.Models.Areceber", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataInativacao")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataRecebimento")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataReferencia")
                        .HasColumnType("timestamp");

                    b.Property<DateTime>("DataVencimento")
                        .HasColumnType("timestamp");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<long>("IdNaturezaDeLancamento")
                        .HasColumnType("bigint");

                    b.Property<long>("IdUsuario")
                        .HasColumnType("bigint");

                    b.Property<string>("Observacao")
                        .HasColumnType("VARCHAR");

                    b.Property<double>("ValorOriginal")
                        .HasColumnType("double precision");

                    b.Property<double>("ValorRecebido")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.HasIndex("IdNaturezaDeLancamento");

                    b.HasIndex("IdUsuario");

                    b.ToTable("areceber", (string)null);
                });

            modelBuilder.Entity("ControleFacil.Api.Models.NaturezaDeLancamento", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataInativacao")
                        .HasColumnType("timestamp");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<long>("IdUsuario")
                        .HasColumnType("bigint");

                    b.Property<string>("Observacao")
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("IdUsuario");

                    b.ToTable("naturezaDeLancamento", (string)null);
                });

            modelBuilder.Entity("ControleFacil.Api.Models.Usuario", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("timestamp");

                    b.Property<DateTime?>("DataInativacao")
                        .HasColumnType("timestamp");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("usuario", (string)null);
                });

            modelBuilder.Entity("ControleFacil.Api.Models.Apagar", b =>
                {
                    b.HasOne("ControleFacil.Api.Models.NaturezaDeLancamento", "NaturezaDeLancamento")
                        .WithMany()
                        .HasForeignKey("IdNaturezaDeLancamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleFacil.Api.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NaturezaDeLancamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ControleFacil.Api.Models.Areceber", b =>
                {
                    b.HasOne("ControleFacil.Api.Models.NaturezaDeLancamento", "NaturezaDeLancamento")
                        .WithMany()
                        .HasForeignKey("IdNaturezaDeLancamento")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleFacil.Api.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NaturezaDeLancamento");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ControleFacil.Api.Models.NaturezaDeLancamento", b =>
                {
                    b.HasOne("ControleFacil.Api.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
