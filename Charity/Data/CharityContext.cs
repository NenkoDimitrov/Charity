using Microsoft.EntityFrameworkCore;

namespace Charity.Data
{
    public class CharityContext:DbContext
    {
        public CharityContext(DbContextOptions<CharityContext> op) : base(op) 
        {
            
        }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Activities> Product { get; set; }
        public virtual DbSet<ActivitiesExecution> ActivitiesExecution { get; set; }
    }
}
