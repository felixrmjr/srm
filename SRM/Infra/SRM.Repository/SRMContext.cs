using SRM.Domain.Entities;
using SRM.Domain.Repository;
using SRM.Repository.Maps;
using System.Data.Entity;

namespace SRM.Repository
{
    public class SRMContext : DbContext, IUnitOfWork<SRMContext>
    {
        public SRMContext() : base("name=SRMDb") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new ClienteMap());
        }

        public virtual DbSet<Cliente> Clientes { get; set; }

        public int Commit() => this.SaveChanges();
    }
}