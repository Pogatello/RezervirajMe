using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RezervirajMe.WebBlazor.Data.Model
{
	public class Appointment
	{
		public long Id { get; set; }

		public bool IsActive { get; set; }

		public DateTime Start { get; set; }

		public DateTime End { get; set; }

		public bool IsConfirmed { get; set; }

		public long ReservationId { get; set; }

		public Reservation Reservation { get; set; }
	}
}
