using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RezervirajMe.Contract;
using RezervirajMe.Infrasturcture;
using RezervirajMe.Model;
using RezervirajMe.Model.Contract;
using RezervirajMe.Repository;
using RezervirajMe.Repository.Context;
using RezervirajMe.Service;

namespace RezervirajMe.API.IOC
{
	public static class ServiceConfiguration
	{
		public static void ConfigureServices(this IServiceCollection services, IConfiguration configuration)
		{
			ConfigureApi(services);
			ConfigureApplicationServices(services);
			ConfigureAutoMapper(services);
			ConfigureRepositories(services);
			ConfigureDbContexts(services, configuration);
		}

		#region Private methods

		private static void ConfigureApi(IServiceCollection services)
		{
			services.AddApiVersioning(o =>
			{
				o.ReportApiVersions = true;
				o.AssumeDefaultVersionWhenUnspecified = true;
				o.DefaultApiVersion = new ApiVersion(1, 0);
			});
		}

		private static void ConfigureApplicationServices(IServiceCollection services)
		{
			services.AddTransient<IReservationService, ReservationService>();
		}

		private static void ConfigureAutoMapper(IServiceCollection services)
		{
			//var mappingConfig = new MapperConfiguration(mc =>
			//{
			//	mc.AddProfile(new CustomerMappingProfile());
			//});

			//services.AddSingleton(mappingConfig.CreateMapper());
		}

		private static void ConfigureRepositories(IServiceCollection services)
		{
			services.AddTransient<IReservationRepository, ReservationRepository>();
		}

		private static void ConfigureDbContexts(IServiceCollection services, IConfiguration configuration)
		{
			var dbConfig = configuration.GetSection(nameof(DatabaseConfiguration)).Get<DatabaseConfiguration>();

			services
				.AddDbContext<ReservationDbContext>
				(
					options => options.UseSqlServer(dbConfig.RezervirajMeDbConnectionString), ServiceLifetime.Singleton
				);

			//services
			//	.AddDbContext<UserDbContext>
			//	(
			//		options => options.UseSqlServer(dbConfig.RezervirajMeDbConnectionString), ServiceLifetime.Singleton
			//	);

			//services.AddIdentity<User, IdentityRole>()
			//		.AddEntityFrameworkStores<UserDbContext>();
		}

		#endregion
	}
}
