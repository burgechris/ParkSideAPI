﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkSideAPI.Models;

namespace ParkSideAPI.Migrations
{
    [DbContext(typeof(ParkSideAPIContext))]
    [Migration("20191101225754_SeedData2")]
    partial class SeedData2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkSideAPI.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Area");

                    b.Property<string>("Coordinates");

                    b.Property<int>("Established");

                    b.Property<string>("GoverningBody");

                    b.Property<string>("Name");

                    b.Property<string>("StateLocation");

                    b.Property<string>("Website");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");

                    b.HasData(
                        new
                        {
                            ParkId = 1,
                            Area = "2,219,791 acres",
                            Coordinates = "44°36′N 110°30′W",
                            Established = 1872,
                            GoverningBody = "National Park Service",
                            Name = "Yellowstone National Park",
                            StateLocation = "Wyoming",
                            Website = "https://www.nps.gov/yell/index.htm"
                        },
                        new
                        {
                            ParkId = 2,
                            Area = "49,075.26 acres",
                            Coordinates = "44.35°N 68.21°W",
                            Established = 1919,
                            GoverningBody = "National Park Service",
                            Name = "Acadia National Park",
                            StateLocation = "Maine",
                            Website = "https://www.nps.gov/acad/index.htm"
                        },
                        new
                        {
                            ParkId = 3,
                            Area = "183,224.05 acres",
                            Coordinates = "42.94°N 122.1°W",
                            Established = 1902,
                            GoverningBody = "National Park Service",
                            Name = "Crater Lake National Park",
                            StateLocation = "Oregon",
                            Website = "https://www.nps.gov/crla/index.htm"
                        },
                        new
                        {
                            ParkId = 4,
                            Area = "3,372,981.42 acres",
                            Coordinates = "36.24°N 116.82°W",
                            Established = 1994,
                            GoverningBody = "National Park Service",
                            Name = "Death Valley Lake National Park",
                            StateLocation = "California",
                            Website = "https://www.nps.gov/deva/index.htm"
                        },
                        new
                        {
                            ParkId = 5,
                            Area = "1,013,125.99 acres",
                            Coordinates = "48.80°N 114.00°W",
                            Established = 1910,
                            GoverningBody = "National Park Service",
                            Name = "Glacier Lake National Park",
                            StateLocation = "Montana",
                            Website = "https://www.nps.gov/glac/index.htm"
                        },
                        new
                        {
                            ParkId = 6,
                            Area = "310,044.36 acres",
                            Coordinates = "43.73°N 110.80°W",
                            Established = 1929,
                            GoverningBody = "National Park Service",
                            Name = "Grand Teton Lake National Park",
                            StateLocation = "Wyoming",
                            Website = "https://www.nps.gov/grte/index.htm"
                        },
                        new
                        {
                            ParkId = 7,
                            Area = "325,605.28 acres",
                            Coordinates = "20.72°N 156.17°W",
                            Established = 1916,
                            GoverningBody = "National Park Service",
                            Name = "Haleakala National Park",
                            StateLocation = "Hawaii",
                            Website = "https://www.nps.gov/hale/index.htm"
                        },
                        new
                        {
                            ParkId = 8,
                            Area = "790,635.74 acres",
                            Coordinates = "33.79°N 115.90°W",
                            Established = 1994,
                            GoverningBody = "National Park Service",
                            Name = "Joshua Tree National Park",
                            StateLocation = "California",
                            Website = "https://www.nps.gov/jotr/index.htm"
                        },
                        new
                        {
                            ParkId = 9,
                            Area = "52,485.17 acres",
                            Coordinates = "37.18°N 108.49°W",
                            Established = 1906,
                            GoverningBody = "National Park Service",
                            Name = "Mesa Verde National Park",
                            StateLocation = "Colorado",
                            Website = "https://www.nps.gov/meve/index.htm"
                        },
                        new
                        {
                            ParkId = 10,
                            Area = "504,780.94 acres",
                            Coordinates = "48.70°N 121.20°W",
                            Established = 1968,
                            GoverningBody = "National Park Service",
                            Name = "North Cascades National Park",
                            StateLocation = "Washington",
                            Website = "https://www.nps.gov/noca/index.htm"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}