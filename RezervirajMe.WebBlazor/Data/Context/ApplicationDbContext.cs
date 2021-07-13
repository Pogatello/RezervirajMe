using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RezervirajMe.WebBlazor.Data.Model;

namespace RezervirajMe.WebBlazor.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{

		public virtual DbSet<Reservation> Reservations { get; set; }

		public virtual DbSet<Appointment> Appointments { get; set; }


		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}
	}
}
