using System.Threading.Tasks;

namespace RezervirajMe.WebBlazor.Data.Contract
{
	public interface IReservationService
	{
		Task<bool> Get();
	}
}
