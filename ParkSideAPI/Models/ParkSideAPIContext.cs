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
  }
}