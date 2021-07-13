using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RezervirajMe.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RezervirajMe.Repository.Context
{
	public class UserDbContext : IdentityDbContext
	{
		#region Properties

		public virtual DbSet<User> Reservations { get; set; }


		#endregion

		#region Constructors

		public UserDbContext(DbContextOptions<UserDbContext> options)
		: base(options)
		{
		}

		#endregion

		#region Override methods

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfigurationsFromAssembly(typeof(UserDbContext).Assembly);
		}

		#endregion
	}
}
