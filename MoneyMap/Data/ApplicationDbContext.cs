using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyMap.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<Cash_Flow> cash_flow{get;set;}
        public DbSet<Net_Worth> money_map{get;set;}
    }

}
