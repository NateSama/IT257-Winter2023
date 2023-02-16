﻿// <auto-generated />
using System;
using IT257_Winter2023.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IT257_Winter2023.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    partial class ApplicationDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IT257_Winter2023.Models.Games.ConsoleModel", b =>
                {
                    b.Property<int>("ConsoleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsoleName");

                    b.HasKey("ConsoleId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Consoles");
                });

            modelBuilder.Entity("IT257_Winter2023.Models.Games.GameModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ConsoleId");

                    b.Property<string>("Description");

                    b.Property<int>("GenreId");

                    b.Property<string>("Name");

                    b.Property<DateTime>("ReleaseDate");

                    b.HasKey("Id")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.HasIndex("ConsoleId");

                    b.HasIndex("GenreId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("IT257_Winter2023.Models.Games.GenreModel", b =>
                {
                    b.Property<int>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GenreName");

                    b.HasKey("GenreId")
                        .HasAnnotation("SqlServer:Clustered", false);

                    b.ToTable("Genres");
                });

            modelBuilder.Entity("IT257_Winter2023.Models.Ratings.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GameId");

                    b.Property<int?>("GameId1");

                    b.Property<int>("ProviderID");

                    b.Property<string>("RatingValue");

                    b.HasKey("Id");

                    b.HasIndex("GameId1");

                    b.HasIndex("ProviderID");

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("IT257_Winter2023.Models.Ratings.RatingsProvider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ProviderName");

                    b.HasKey("Id");

                    b.ToTable("RatingsProviders");
                });

            modelBuilder.Entity("IT257_Winter2023.Models.Games.GameModel", b =>
                {
                    b.HasOne("IT257_Winter2023.Models.Games.ConsoleModel", "Console")
                        .WithMany("Games")
                        .HasForeignKey("ConsoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("IT257_Winter2023.Models.Games.GenreModel", "Genre")
                        .WithMany("Games")
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("IT257_Winter2023.Models.Ratings.Rating", b =>
                {
                    b.HasOne("IT257_Winter2023.Models.Games.GameModel", "Game")
                        .WithMany()
                        .HasForeignKey("GameId1");

                    b.HasOne("IT257_Winter2023.Models.Ratings.RatingsProvider", "Provider")
                        .WithMany("Ratings")
                        .HasForeignKey("ProviderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
