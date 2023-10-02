using System;
using System.Threading.Tasks;
using ControleFacil.Api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ControleFacil.Api.Data.Mappings
{
    public class NaturezaDeLancamentoMap : IEntityTypeConfiguration<NaturezaDeLancamento>
    {
        public void Configure(EntityTypeBuilder<NaturezaDeLancamento> builder)
        {
            builder.ToTable("naturezaDeLancamento")
            .HasKey(p => p.Id);

            builder.HasOne(p => p.Usuario)
            .WithMany()
            .HasForeignKey(fk => fk.IdUsuario);

            builder.Property(p => p.Descricao)
            .HasColumnType("VARCHAR")
            .IsRequired();

            builder.Property(p => p.Observacao)
            .HasColumnType("VARCHAR");

            builder.Property(p => p.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired();

            builder.Property(p => p.DataInativacao)
            .HasColumnType("timestamp");
        }


    }
}