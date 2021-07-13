using System.Collections.Generic;

namespace RezervirajMe.Model
{
	public class Reservation
	{
		public long Id { get; set; }

		public bool IsActive { get; set; }

		public string UrlString { get; set; }

		public byte[] LogoImage { get; set; }

		public string Title { get; set; }

		//enum every day, month repeating il neš tako

		public IEnumerable<Appointment> Appointments { get; set; }

	}
}
