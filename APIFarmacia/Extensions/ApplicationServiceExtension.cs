

using Application.UnitOfWork;
using Domain.Interfaces;
using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace APIFarmacia.Extensions;
    public static class ApplicationServiceExtension
    {

    public static void ConfigureCors(this IServiceCollection services) =>
        services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder.AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader());
        });

    public static void AddApplicationServices(this IServiceCollection services)
    {
        //services.AddScoped<IPais, PaisRepository>();
        //servies.AddScoped<ITipoPersona, TipoPersonaRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    }

    public static void ConfigureRateLimit(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        services.AddInMemoryRateLimiting();
        services.Configure<IpRateLimitOptions>(options =>
        {
            options.EnableEndpointRateLimiting = true;
            options.StackBlockedRequests = false;
            options.HttpStatusCode = 429;
            options.RealIpHeader = "X-Real-IP";
            options.GeneralRules = new List<RateLimitRule>
            {
                new RateLimitRule
                {
                    Endpoint = "*",
                    Period = "10s",
                    Limit = 5
                }
            };
        });
    }

    // public static void ConfigureApiVersioning(this IServiceCollection services)
    // {
    //     services.AddApiVersioning(options =>
    //     {
    //         options.DefaultApiVersion = new ApiVersion(1, 0);
    //         options.AssumeDefaultVersionWhenUnspecified = true;
    //         //Para una versión 
    //         //options.ApiVersionReader = new QueryStringApiVersionReader("ver");

    //         //Para ambas versiones
    //         options.ApiVersionReader = ApiVersionReader.Combine(
    //             new QueryStringApiVersionReader("ver"),
    //             new HeaderApiVersionReader ("X-Version")
    //         );
    //     });
    // }
    }
