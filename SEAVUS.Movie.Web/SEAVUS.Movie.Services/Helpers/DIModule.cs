using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SEAVUS.Movie.DataAccess;
using SEAVUS.Movie.DataAccess.Interfaces;
using SEAVUS.Movie.DataAccess.Repositories;
using SEAVUS.Movie.Domain.Models;
using SEAVUS.Movie.Services.Interfaces;
using SEAVUS.Movie.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEAVUS.Movie.Services.Helpers
{
    public class DIModule
    {
        public static IServiceCollection RegisterModule(IServiceCollection services, string connectionString)
        {
            services.AddDbContextPool<MovieDbContext>(
                dbContextOptions => dbContextOptions
                                    .UseMySql(connectionString));

            services.AddIdentity<User, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
            })
           .AddRoleManager<RoleManager<IdentityRole>>()
           .AddEntityFrameworkStores<MovieDbContext>()
           .AddDefaultTokenProviders();

            services.AddTransient<IRepository<Domain.Models.Movie>, MovieRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IRepository<Actor>, ActorRepository>();
            services.AddTransient<IRepository<Ticket>, TicketRepository>();
            services.AddTransient<IRepository<Show>, ShowRepository>();
            services.AddTransient<IRepository<Seat>, SeatRepository>();
            services.AddTransient<IRepository<Reservation>, ReservationRepository>();
            services.AddTransient<IRepository<Seat>, SeatRepository>();
            services.AddTransient<IRepository<Hall>, HallRepository>();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMovieService, MovieService>();
            services.AddTransient<IActorService, ActorService>();
            services.AddTransient<IReservationService, ReservationService>();
            services.AddTransient<ISeatService, SeatService>();
            services.AddTransient<IHallService, HallService>();



            return services;
        }
    }
}
