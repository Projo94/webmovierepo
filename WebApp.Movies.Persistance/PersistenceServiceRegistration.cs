
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebApp.Movies.Application.Contracts.Persistence;
using WebApp.Movies.Persistance.Repositories;

namespace WebApp.Movies.Persistance
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MoviesDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MoviesConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));


            services.AddScoped<IActorTVProgramRepository, ActorTVProgramRepository>();
            services.AddScoped<IActorRepository, ActorRepository>();
            services.AddScoped<ITVProgramRatingRepository, TVProgramRatingRepository>();
            services.AddScoped<ITVProgramRatingRepository, TVProgramRatingRepository>();
            services.AddScoped<ITVProgramRepository, TVProgramRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
