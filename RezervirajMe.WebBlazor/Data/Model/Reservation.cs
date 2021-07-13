using System;
using System.Collections.Generic;

namespace RezervirajMe.WebBlazor.Data.Model
{
	public class Reservation
	{
		public long Id { get; set; }

		public bool IsActive { get; set; }

		public byte[] LogoImage { get; set; }

		public string Title { get; set; }

		//enum every day, month repeating il neš tako

		public Guid UserId { get; set; }

		public IEnumerable<Appointment> Appointments { get; set; }
	}
}
