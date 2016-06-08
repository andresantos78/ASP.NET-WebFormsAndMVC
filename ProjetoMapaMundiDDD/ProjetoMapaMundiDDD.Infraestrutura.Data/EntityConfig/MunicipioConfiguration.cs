using ProjetoMapaMundiDDD.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoMapaMundiDDD.Infraestrutura.Data.EntityConfig
{
    public class MunicipioConfiguration : EntityTypeConfiguration<Municipio>
    {
        public MunicipioConfiguration()
        {
            HasKey(m => m.MunicipioID);

        }
    }
}
