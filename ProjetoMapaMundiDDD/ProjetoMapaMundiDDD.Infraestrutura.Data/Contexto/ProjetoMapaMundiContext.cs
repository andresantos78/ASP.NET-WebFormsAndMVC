using ProjetoMapaMundiDDD.Domain.Entidades;
using ProjetoMapaMundiDDD.Infraestrutura.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace ProjetoMapaMundiDDD.Infraestrutura.Data.Contexto
{
    public class ProjetoMapaMundiContext : DbContext
    {
        public ProjetoMapaMundiContext() : base("ProjetoMapaMundiDDD")
        { }

        public DbSet<Continente> Continentes { get; set;}
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "ID")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new ContinenteConfiguration());
            modelBuilder.Configurations.Add(new PaisConfiguration());
            modelBuilder.Configurations.Add(new EstadoConfiguration());
            modelBuilder.Configurations.Add(new MunicipioConfiguration());
        }


        public override int SaveChanges()
        {
            foreach(var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }
            return base.SaveChanges();
        }

    }
}
