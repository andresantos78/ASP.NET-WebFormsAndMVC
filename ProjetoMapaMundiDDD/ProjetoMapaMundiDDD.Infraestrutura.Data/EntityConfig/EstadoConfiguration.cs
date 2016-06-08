using ProjetoMapaMundiDDD.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMapaMundiDDD.Infraestrutura.Data.EntityConfig
{
    public class EstadoConfiguration : EntityTypeConfiguration<Estado>
    {
        public EstadoConfiguration()
        {
            HasKey(e => e.EstadoID);

            Property(e => e.Sigla)
                .IsRequired()
                .HasMaxLength(2);
        }
    }
}
