using Microsoft.EntityFrameworkCore;

namespace RestuarantReservationSystem.Models
{
    public class DatabaseContext:DbContext
    {
        
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        
        public DbSet<Account> Account { get; set; }

        public DbSet<Reservation> Reservation { get; set; }
        
    }
}
