using Microsoft.EntityFrameworkCore;

namespace ParkSideAPI.Models
{
  public class ParkSideAPIContext : DbContext
  {
    public ParkSideAPIContext(DbContextOptions<ParkSideAPIContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }
    
    protected override void OnModelCreating (ModelBuilder builder)
    {
          builder.Entity<Park>()
          .HasData(
              new Park { ParkId = 1, Name = "Yellowstone National Park", GoverningBody = "National Park Service", StateLocation = "Wyoming", Established = 1872, Coordinates = "44°36′N 110°30′W", Area = "2,219,791 acres", Website = "https://www.nps.gov/yell/index.htm" }
          );
    }
  }
}