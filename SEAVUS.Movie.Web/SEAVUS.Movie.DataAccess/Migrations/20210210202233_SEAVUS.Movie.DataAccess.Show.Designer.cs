﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SEAVUS.Movie.DataAccess;

namespace SEAVUS.Movie.DataAccess.Migrations
{
    [DbContext(typeof(MovieDbContext))]
    [Migration("20210210202233_SEAVUS.Movie.DataAccess.Show")]
    partial class SEAVUSMovieDataAccessShow
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new { Id = "ec96ece2-8b64-4c6c-b1c1-f2cb31798bf1", ConcurrencyStamp = "53c9a3d2-fa43-4300-b3f6-ec4f7e8af3b6", Name = "admin", NormalizedName = "Administrator" },
                        new { Id = "8f6f49a1-6cb0-4532-bdc8-55f15181b253", ConcurrencyStamp = "04b495af-5f70-429f-916a-da4a9b11dbd6", Name = "user", NormalizedName = "User" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new { UserId = "d5bd8313-40cf-48a8-a2c9-e2e47b78f2b1", RoleId = "ec96ece2-8b64-4c6c-b1c1-f2cb31798bf1" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Age");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("Id");

                    b.ToTable("Actors");

                    b.HasData(
                        new { Id = 1, Age = 41, FirstName = "Patrick", LastName = "Wilson" },
                        new { Id = 2, Age = 30, FirstName = "Elizabeth", LastName = "Debicki" },
                        new { Id = 3, Age = 26, FirstName = "Julia", LastName = "Garner" },
                        new { Id = 4, Age = 42, FirstName = "Andy", LastName = "Samberg" },
                        new { Id = 5, Age = 35, FirstName = "Cristin", LastName = "Milioti" },
                        new { Id = 6, Age = 60, FirstName = "Hatidze", LastName = "Muratova" },
                        new { Id = 7, Age = 53, FirstName = "Song", LastName = "Kang-ho" },
                        new { Id = 8, Age = 59, FirstName = "George", LastName = "Clooney" },
                        new { Id = 9, Age = 40, FirstName = "Chris", LastName = "Pine" },
                        new { Id = 10, Age = 40, FirstName = "Margot", LastName = "Robbie" },
                        new { Id = 11, Age = 34, FirstName = "Christopher", LastName = "Abbott" },
                        new { Id = 12, Age = 33, FirstName = "Liu", LastName = "Yifei" }
                    );
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Cast", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ActorId");

                    b.Property<int>("MovieId");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("MovieId");

                    b.ToTable("Cast");

                    b.HasData(
                        new { Id = 1, ActorId = 2, MovieId = 1 },
                        new { Id = 2, ActorId = 4, MovieId = 2 },
                        new { Id = 3, ActorId = 1, MovieId = 3 },
                        new { Id = 4, ActorId = 6, MovieId = 4 },
                        new { Id = 5, ActorId = 7, MovieId = 5 },
                        new { Id = 6, ActorId = 8, MovieId = 6 },
                        new { Id = 7, ActorId = 9, MovieId = 7 },
                        new { Id = 8, ActorId = 10, MovieId = 8 },
                        new { Id = 9, ActorId = 11, MovieId = 9 },
                        new { Id = 10, ActorId = 12, MovieId = 10 },
                        new { Id = 11, ActorId = 3, MovieId = 3 },
                        new { Id = 12, ActorId = 5, MovieId = 2 }
                    );
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Hall", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Halls");

                    b.HasData(
                        new { Id = 1, Name = "Hall 01", Type = "Standard" }
                    );
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Director");

                    b.Property<string>("Genre");

                    b.Property<string>("Image");

                    b.Property<string>("Language");

                    b.Property<DateTime>("ReleaseDate");

                    b.Property<string>("Technology");

                    b.Property<string>("Title");

                    b.Property<string>("Trailer");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new { Id = 1, Description = "She is a angel princess from the angel world. She grew up loved by her parents and doesn't really know how to be evil or any of the common actions,   She is unable to cry due to Keita's accidental first wish, despite needed for him to wish.", Director = "Christopher Nolan", Genre = "Action/Sci-fi", Language = "English", ReleaseDate = new DateTime(2020, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Tenet" },
                        new { Id = 2, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Max Barbakow", Genre = "Romantic comedy", Language = "English", ReleaseDate = new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Palm Springs" },
                        new { Id = 3, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Kitty Green", Genre = "Drama", Language = "English", ReleaseDate = new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "The Assistant" },
                        new { Id = 4, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Tamara Kotevska", Genre = "Documentary", Language = "Macedonian", ReleaseDate = new DateTime(2019, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Honeyland" },
                        new { Id = 5, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Bong Joon-ho", Genre = "Dark comedy", Language = "Korean", ReleaseDate = new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Parasite" },
                        new { Id = 6, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "George Clooney", Genre = "Action/Sci-fi", Language = "English", ReleaseDate = new DateTime(2020, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "The midnight sky" },
                        new { Id = 7, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Patty Jenkins", Genre = "Action/Sci-fi", Language = "English", ReleaseDate = new DateTime(2020, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Wonder Woman" },
                        new { Id = 8, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Cathy Yan", Genre = "Action", Language = "English", ReleaseDate = new DateTime(2020, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Birds of Prey" },
                        new { Id = 9, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Brandon Cronenberg", Genre = "Sci-fi/Horror", Language = "English", ReleaseDate = new DateTime(2020, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Possessor" },
                        new { Id = 10, Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.", Director = "Niki Caro", Genre = "Action", Language = "English", ReleaseDate = new DateTime(2020, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), Technology = "2D", Title = "Mulan" }
                    );
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Reservation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Price");

                    b.Property<DateTime>("ReservationDate");

                    b.Property<int>("SeatId");

                    b.Property<int>("ShowId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Seat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<sbyte>("Available");

                    b.Property<int>("HallId");

                    b.Property<decimal>("Price");

                    b.Property<int>("RowNumber");

                    b.Property<int>("SeatNumber");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.ToTable("Seats");

                    b.HasData(
                        new { Id = 1, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 1, Type = "Standard" },
                        new { Id = 2, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 2, Type = "Standard" },
                        new { Id = 3, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 3, Type = "Standard" },
                        new { Id = 4, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 4, Type = "Standard" },
                        new { Id = 5, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 5, Type = "Standard" },
                        new { Id = 6, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 6, Type = "Standard" },
                        new { Id = 7, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 7, Type = "Standard" },
                        new { Id = 8, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 8, Type = "Standard" },
                        new { Id = 9, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 9, Type = "Standard" },
                        new { Id = 10, Available = (sbyte)1, HallId = 1, Price = 9.00m, RowNumber = 1, SeatNumber = 10, Type = "Standard" }
                    );
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("HallId");

                    b.Property<int>("MovieId");

                    b.Property<DateTime>("ShowTime");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("HallId");

                    b.HasIndex("MovieId");

                    b.ToTable("Shows");

                    b.HasData(
                        new { Id = 1, EndDate = new DateTime(2020, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), HallId = 1, MovieId = 1, ShowTime = new DateTime(2020, 9, 10, 1, 0, 0, 0, DateTimeKind.Unspecified), StartDate = new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 2, EndDate = new DateTime(2020, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), HallId = 1, MovieId = 2, ShowTime = new DateTime(2020, 2, 10, 2, 0, 0, 0, DateTimeKind.Unspecified), StartDate = new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 3, EndDate = new DateTime(2020, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), HallId = 1, MovieId = 3, ShowTime = new DateTime(2001, 1, 20, 4, 0, 0, 0, DateTimeKind.Unspecified), StartDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 4, EndDate = new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), HallId = 1, MovieId = 4, ShowTime = new DateTime(2019, 6, 5, 3, 0, 0, 0, DateTimeKind.Unspecified), StartDate = new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                        new { Id = 5, EndDate = new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), HallId = 1, MovieId = 5, ShowTime = new DateTime(2019, 10, 1, 3, 0, 0, 0, DateTimeKind.Unspecified), StartDate = new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                    );
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal?>("Price");

                    b.Property<int?>("ReservationId");

                    b.Property<int>("SeatId");

                    b.Property<int>("ShowId");

                    b.Property<int>("TicketNumber");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("SeatId");

                    b.HasIndex("ShowId");

                    b.HasIndex("UserId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTime?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new { Id = "d5bd8313-40cf-48a8-a2c9-e2e47b78f2b1", AccessFailedCount = 0, ConcurrencyStamp = "103c4aeb-8d47-4037-92ae-72ff362714ed", Email = "angelaadmin@gmail.com", EmailConfirmed = true, LockoutEnabled = false, NormalizedEmail = "angelaadmin@gmail.com", NormalizedUserName = "ADMIN", PasswordHash = "AQAAAAEAACcQAAAAEMWWs0+1S+0TWJoZh6HKp+LhfpGAM1ljmJJSWMwEPJ/qIY73pentyaUuCbKqJN0UvQ==", PhoneNumberConfirmed = false, SecurityStamp = "", TwoFactorEnabled = false, UserName = "AngelaAdmin" }
                    );
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Cast", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.Actor", "Actor")
                        .WithMany("MovieCast")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.Movie", "Movie")
                        .WithMany("MovieCast")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Reservation", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.Seat", "Seat")
                        .WithMany("Reservations")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.Show", "Show")
                        .WithMany("Reservations")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.User", "User")
                        .WithMany("Reservations")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Seat", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.Hall", "Hall")
                        .WithMany("Seats")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Show", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.Hall", "Hall")
                        .WithMany("Shows")
                        .HasForeignKey("HallId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.Movie", "Movie")
                        .WithMany("Shows")
                        .HasForeignKey("MovieId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SEAVUS.Movie.Domain.Models.Ticket", b =>
                {
                    b.HasOne("SEAVUS.Movie.Domain.Models.Reservation", "Reservation")
                        .WithMany("Tickets")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.Seat", "Seat")
                        .WithMany("Tickets")
                        .HasForeignKey("SeatId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.Show", "Show")
                        .WithMany("Tickets")
                        .HasForeignKey("ShowId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SEAVUS.Movie.Domain.Models.User", "User")
                        .WithMany("Tickets")
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
