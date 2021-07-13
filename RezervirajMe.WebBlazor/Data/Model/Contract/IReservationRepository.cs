using System.Collections.Generic;
using System.Threading.Tasks;

namespace RezervirajMe.WebBlazor.Data.Model.Contract
{
	public interface IReservationRepository
	{
		Task<IEnumerable<Reservation>> GetReservationAsync();

		Task<Reservation> GetReservationAsync(long id);

		Task CreateReservationAsync(Reservation reservation);
	}
}
