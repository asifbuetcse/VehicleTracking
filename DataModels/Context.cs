using Microsoft.EntityFrameworkCore;
namespace VehicleTracking.DataModels
{
    public class Context: DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Vehicle> Vehicles { get; set; }
        DbSet<TrackingCurrent> TrackingCurrents { get; set;}
        DbSet<TrackingHistory> TrackingHistories { get; set; }

        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-48T0DGR\SQLEXPRESS;Database=VehicleTracking;Trusted_Connection=True;");
        }
    }
}
