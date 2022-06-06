using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class RadiusContext:DbContext
    {
        public RadiusContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database = Radius; Trusted_Connection=true", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Kullanicilar> kullanicilars { get; set; }
        public DbSet<Yetkiler> yetkilers { get; set; }
        public DbSet<AdresBilgileri> adresBilgileris { get; set; }
        public DbSet<İcerik>iceriks { get; set; }







    }
}
