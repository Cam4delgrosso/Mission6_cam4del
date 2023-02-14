using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6_cam4del.Models
{
    public class MovieInfoContext : DbContext
    {
        //Constructor
        public MovieInfoContext(DbContextOptions<MovieInfoContext> options) : base(options)
        {
            //Leave Blank for now
        }

        public DbSet<ApplicationResponse> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(
                new ApplicationResponse
                {
                    MovieId = 1,
                    category = "Action",
                    title = "2 Fast 2 Furious",
                    year = 2003,
                    director = "John Singleton",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "Cameron Delgrosso",
                    notes = "Very fast, not very furious"
                },
                new ApplicationResponse
                {
                    MovieId = 2,
                    category = "Comedy",
                    title = "21 Jump Street",
                    year = 2012,
                    director = "Phil Lord",
                    rating = "R",
                    edited = true,
                    lent_to = "Cameron Delgrosso",
                    notes = "Jonah Hill is funny"
                },
                new ApplicationResponse
                {
                    MovieId = 3,
                    category = "Action",
                    title = "Top Gun Maverick",
                    year = 2022,
                    director = "Joseph Kosinski",
                    rating = "PG-13",
                    edited = false,
                    lent_to = "Cameron Delgrosso",
                    notes = "Gave me chills"
                }

                );
        }
    }
}
