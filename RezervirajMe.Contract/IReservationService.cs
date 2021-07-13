using System.Threading.Tasks;

namespace RezervirajMe.Contract
{
	public interface IReservationService
	{
		Task<bool> Get();
	}
}
