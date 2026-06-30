using CleanArchitecture.Application.Services;
using CleanArchitecture.Domain.Modules.Accounts.Users;
using CleanArchitecture.Infrastructure.Context;
using CleanArchitecture.Infrastructure.Options;
using CleanArchitecture.Infrastructure.Services;
using GenericRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Scrutor;
using System.Security.Claims;
using System.Text;

namespace CleanArchitecture.Infrastructure
{
    public static class InfrastructureRegistrar
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(opt =>
            {
                string connectionString = configuration.GetConnectionString("SqlServer")!;
                opt.UseSqlServer(connectionString);
            });

            services.AddScoped<IUnitOfWork>(srv => srv.GetRequiredService<ApplicationDbContext>());

            services
                .AddIdentity<AppUser, IdentityRole<int>>(opt =>
                {
                    opt.Password.RequiredLength = 1;
                    opt.Password.RequireNonAlphanumeric = false;
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireUppercase = false;
                    opt.Lockout.MaxFailedAccessAttempts = 5;
                    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                    opt.SignIn.RequireConfirmedEmail = false;
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.Configure<JwtOptions>(configuration.GetSection("Jwt"));
            services.ConfigureOptions<JwtOptionsSetup>();
            //services.Configure<KeycloakConfiguration>(configuration.GetSection("KeycloakConfiguration"));

            //services.AddScoped<KeycloakService>();
            services.AddScoped<IJwtProvider, JwtProvider>();

            var jwt = configuration.GetSection("Jwt").Get<JwtOptions>();
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwt.SecretKey));

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = false;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwt.Issuer,
                    ValidateAudience = true,
                    ValidAudience = jwt.Audience,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = key,
                    ValidateLifetime = true,
                    ClockSkew = TimeSpan.FromMinutes(10),
                    NameClaimType = ClaimTypes.NameIdentifier,
                    RoleClaimType = "role" // adjust if your token uses different claim
                };

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = ctx => {
                        // optional: log or inspect incoming token for debugging
                        return Task.CompletedTask;
                    },
                    OnAuthenticationFailed = ctx => {
                        // optional: log ctx.Exception
                        return Task.CompletedTask;
                    }
                };
            });

            services.Scan(opt => opt
            .FromAssemblies(typeof(InfrastructureRegistrar).Assembly)
            .AddClasses(publicOnly: false)
            .UsingRegistrationStrategy(RegistrationStrategy.Skip)
            .AsImplementedInterfaces()
            .WithScopedLifetime()
            );

            return services;
        }
    }
}
