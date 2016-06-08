using ProjetoMapaMundiDDD.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMapaMundiDDD.Infraestrutura.Data.EntityConfig
{
    public class ContinenteConfiguration : EntityTypeConfiguration<Continente>
    {
        public ContinenteConfiguration()
        {
            HasKey(c => c.ContinenteID);

            Property(c => c.NomeContinente)
                .IsRequired()
                .HasMaxLength(50);
        }


    }
}
