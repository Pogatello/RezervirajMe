using Microsoft.EntityFrameworkCore;
using RezervirajMe.Infrasturcture;
using RezervirajMe.Model;
using RezervirajMe.Model.Contract;
using RezervirajMe.Repository.Context;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RezervirajMe.Repository
{
	public class ReservationRepository : IReservationRepository
	{
		#region Fields

		private readonly ReservationDbContext _dbContext;

		#endregion

		#region Constructors

		public ReservationRepository(ReservationDbContext dbContext)
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
