using Microsoft.EntityFrameworkCore;
using Mosh.Entity;

namespace Mosh.Data
{
    public class MoshDataContext : DbContext
    {
        public MoshDataContext(DbContextOptions<MoshDataContext> options)
            : base(options)
        {
        }

        public DbSet<Mail> Mails { get; set; }
    }
}
