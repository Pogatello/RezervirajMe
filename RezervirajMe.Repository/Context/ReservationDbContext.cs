using Microsoft.EntityFrameworkCore;
using RezervirajMe.Model;

namespace RezervirajMe.Repository.Context
{
	public class ReservationDbContext : DbContext
	{
		#region Properties

		public virtual DbSet<Reservation> Reservations { get; set; }

		public virtual DbSet<Appointment> Appointments { get; set; }

		#endregion

		#region Constructors

		public ReservationDbContext(DbContextOptions<ReservationDbContext> options)
		:base(options)
		{
		}

		#endregion

		#region Override methods

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(ReservationDbContext).Assembly);
		}

		#endregion
	}
}
