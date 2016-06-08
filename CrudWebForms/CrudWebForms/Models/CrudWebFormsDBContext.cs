using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CrudWebForms.Models
{
    public class CrudWebFormsDBContext : DbContext
    {
        public CrudWebFormsDBContext(): base ("CrudWebForms")
        {

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}