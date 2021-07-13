using Microsoft.EntityFrameworkCore;
using RezervirajMe.WebBlazor.Data.Model;
using RezervirajMe.WebBlazor.Data.Model.Contract;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RezervirajMe.WebBlazor.Data.Repository
{
	public class ReservationRepository : IReservationRepository
	{
		#region Fields

		private readonly ApplicationDbContext _dbContext;

		#endregion

		#region Constructors

		public ReservationRepository(ApplicationDbContext dbContext)
		{
			_dbContext = dbContext;
		}

		#endregion

		#region Public Methods

		public async Task<IEnumerable<Reservation>> GetReservationAsync()
		{
			return await _dbContext.Reservations.ToListAsync();
		}

		public async Task<Reservation> GetReservationAsync(long id)
		{
			return await _dbContext.Reservations.SingleOrDefaultAsync(x => x.Id == id);
		}

		public async Task CreateReservationAsync(Reservation reservation)
		{
			throw new System.NotImplementedException();
		}

		#endregion
	}
}
