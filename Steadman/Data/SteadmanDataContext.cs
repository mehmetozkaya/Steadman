using Microsoft.EntityFrameworkCore;
using Steadman.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Steadman.Data
{
    public class SteadmanDataContext : DbContext
    {
        public SteadmanDataContext(DbContextOptions<SteadmanDataContext> options) 
            : base(options)
        {
        }

        public DbSet<Mail> Mails { get; set; }
    }
}
