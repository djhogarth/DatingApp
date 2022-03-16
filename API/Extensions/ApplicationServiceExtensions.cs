using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Helpers;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServiceExtensions
    {
    public static IServiceCollection AddApplicationService(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<IPhotoService, PhotoService>();
            services.Configure<CloudinarySettings>(config.GetSection("CloudinarySettings"));
            services.AddScoped<UpdateUserActivity>();
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<DataContext>(options =>
            {
                // configures the DataContext to connect to a SQLite database and sets the connection string.
                options.UseSqlite(config.GetConnectionString("DefaultConnection"));
            });

        return services;
        }
    }
}
