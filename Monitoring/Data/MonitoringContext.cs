using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParseXmlProj;

namespace Monitoring.Models
{
    public class MonitoringContext : DbContext
    {
        public MonitoringContext (DbContextOptions<MonitoringContext> options)
            : base(options)
        {
        }

        public DbSet<ParseXmlProj.PurchaseContract> PurchaseContract { get; set; }
        public DbSet<ParseXmlProj.PurchaseContractData> PurchaseContractData { get; set; }

    }
}
