using Formulario_Cheques.Context.EntityConfiguration;
using Formulario_Cheques.Context.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols;
using System.Configuration;

namespace Formulario_Cheques.Context
{
    public class ChequeContext : DbContext
    {
        public ChequeContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connString"].ToString();
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ChequeConfiguration()); 
        }

        public DbSet<Cheque> Cheque { get; set; }
    }
}
