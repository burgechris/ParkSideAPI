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
              new Park { ParkId = 1, Name = "Yellowstone National Park", GoverningBody = "National Park Service", StateLocation = "Wyoming", Established = 1872, Coordinates = "44°36′N 110°30′W", Area = "2,219,791 acres", Website = "https://www.nps.gov/yell/index.htm" },

              new Park { ParkId = 2, Name = "Acadia National Park", GoverningBody = "National Park Service", StateLocation = "Maine", Established = 1919, Coordinates = "44.35°N 68.21°W", Area = "49,075.26 acres", Website = "https://www.nps.gov/acad/index.htm" },

              new Park { ParkId = 3, Name = "Crater Lake National Park", GoverningBody = "National Park Service", StateLocation = "Oregon", Established = 1902, Coordinates = "42.94°N 122.1°W", Area = "183,224.05 acres", Website = "https://www.nps.gov/crla/index.htm" },

              new Park { ParkId = 4, Name = "Death Valley Lake National Park", GoverningBody = "National Park Service", StateLocation = "California", Established = 1994, Coordinates = "36.24°N 116.82°W", Area = "3,372,981.42 acres", Website = "https://www.nps.gov/deva/index.htm" },

              new Park { ParkId = 5, Name = "Glacier Lake National Park", GoverningBody = "National Park Service", StateLocation = "Montana", Established = 1910, Coordinates = "48.80°N 114.00°W", Area = "1,013,125.99 acres", Website = "https://www.nps.gov/glac/index.htm" },

              new Park { ParkId = 6, Name = "Grand Teton Lake National Park", GoverningBody = "National Park Service", StateLocation = "Wyoming", Established = 1929, Coordinates = "43.73°N 110.80°W", Area = "310,044.36 acres", Website = "https://www.nps.gov/grte/index.htm" },

              new Park { ParkId = 7, Name = "Haleakala National Park", GoverningBody = "National Park Service", StateLocation = "Hawaii", Established = 1916, Coordinates = "20.72°N 156.17°W", Area = "325,605.28 acres", Website = "https://www.nps.gov/hale/index.htm" },

              new Park { ParkId = 8, Name = "Joshua Tree National Park", GoverningBody = "National Park Service", StateLocation = "California", Established = 1994, Coordinates = "33.79°N 115.90°W", Area = "790,635.74 acres", Website = "https://www.nps.gov/jotr/index.htm" },

              new Park { ParkId = 9, Name = "Mesa Verde National Park", GoverningBody = "National Park Service", StateLocation = "Colorado", Established = 1906, Coordinates = "37.18°N 108.49°W", Area = "52,485.17 acres", Website = "https://www.nps.gov/meve/index.htm" },

              new Park { ParkId = 10, Name = "North Cascades National Park", GoverningBody = "National Park Service", StateLocation = "Washington", Established = 1968, Coordinates = "48.70°N 121.20°W", Area = "504,780.94 acres", Website = "https://www.nps.gov/noca/index.htm" }
          );
    }
  }
}