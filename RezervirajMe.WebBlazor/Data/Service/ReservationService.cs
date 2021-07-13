using RezervirajMe.WebBlazor.Data.Contract;
using RezervirajMe.WebBlazor.Data.Model.Contract;
using System.Threading.Tasks;

namespace RezervirajMe.WebBlazor.Data.Service
{
	public class ReservationService : IReservationService
	{
		#region Fields

		private readonly IReservationRepository _reservationRepository;

		#endregion

		#region Constructors

		public ReservationService(IReservationRepository reservationRepository)
		{
			_reservationRepository = reservationRepository;
		}

		#endregion

		#region Public Methods

		public async Task<bool> Get()
		{
			var a = await _reservationRepository.GetReservationAsync();
			return true;
		}

		#endregion
	}
}
