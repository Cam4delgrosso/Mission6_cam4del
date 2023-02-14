﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission6_cam4del.Models;

namespace Mission6_cam4del.Migrations
{
    [DbContext(typeof(MovieInfoContext))]
    [Migration("20230214020745_Initial3")]
    partial class Initial3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission6_cam4del.Models.ApplicationResponse", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("lent_to")
                        .HasColumnType("TEXT");

                    b.Property<string>("notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieId");

                    b.ToTable("responses");

                    b.HasData(
                        new
                        {
                            MovieId = 1,
                            category = "Action",
                            director = "John Singleton",
                            edited = false,
                            lent_to = "Cameron Delgrosso",
                            notes = "Very fast, not very furious",
                            rating = "PG-13",
                            title = "2 Fast 2 Furious",
                            year = 2003
                        },
                        new
                        {
                            MovieId = 2,
                            category = "Comedy",
                            director = "Phil Lord",
                            edited = true,
                            lent_to = "Cameron Delgrosso",
                            notes = "Jonah Hill is funny",
                            rating = "R",
                            title = "21 Jump Street",
                            year = 2012
                        },
                        new
                        {
                            MovieId = 3,
                            category = "Action",
                            director = "Joseph Kosinski",
                            edited = false,
                            lent_to = "Cameron Delgrosso",
                            notes = "Gave me chills",
                            rating = "PG-13",
                            title = "Top Gun Maverick",
                            year = 2022
                        });
                });
#pragma warning restore 612, 618
        }
    }
}