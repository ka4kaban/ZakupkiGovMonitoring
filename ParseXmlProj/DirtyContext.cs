using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ParseXmlProj
{
    public class DirtyContext : DbContext
    {

        public DirtyContext() : base("DirtyContext")
        {
        }

        public DbSet<PurchaseNotice> PurchaseNotices { get; set; }
        public DbSet<PurchaseContract> PurchaseContracts { get; set; }
        public DbSet<OrderClause> OrderClauses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
