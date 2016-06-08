using System.Data.Entity.ModelConfiguration;
namespace ProjetoMapaMundiDDD.Domain.Entidades
{
    public class PaisConfiguration : EntityTypeConfiguration<Pais>                                     
    {
        public PaisConfiguration()
        {
            HasKey(p => p.PaisID);
        }
    }
}
