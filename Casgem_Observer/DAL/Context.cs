using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Casgem_Observer.DAL
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-FCHRJ42\SQLEXPRESS;initial Catalog=CasgemObserverDb; integrated security=true;trust server certificate=true;");
        }
    


        public DbSet<WelComeMessage> WelComeMessages { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<UserProcess> UserProcesses { get; set; }
    }

}
