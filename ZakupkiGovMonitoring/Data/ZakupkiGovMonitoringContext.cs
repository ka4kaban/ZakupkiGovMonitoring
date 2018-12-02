using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParseXmlProj;

namespace ZakupkiGovMonitoring.Models
{
    public class ZakupkiGovMonitoringContext : DbContext
    {
        public ZakupkiGovMonitoringContext (DbContextOptions<ZakupkiGovMonitoringContext> options)
            : base(options)
        {
        }

        public DbSet<ParseXmlProj.PurchaseContractData> PurchaseContractData { get; set; }
    }
}
