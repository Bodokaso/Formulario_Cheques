using Formulario_Cheques.Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Formulario_Cheques.Context.EntityConfiguration
{
    public class ChequeConfiguration : IEntityTypeConfiguration<Cheque>
    {
        public void Configure(EntityTypeBuilder<Cheque> builder)
        {
            builder.ToTable("Cheque");
            builder.HasKey(x => x.Id);
        }
    }
}
