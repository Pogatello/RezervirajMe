using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RezervirajMe.Contract;
using System.Threading.Tasks;

namespace RezervirajMe.WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ReservationController : ControllerBase
	{
		private readonly ILogger<ReservationController> _logger;
		private readonly IReservationService _reservationService;

		public ReservationController(ILogger<ReservationController> logger, IReservationService reservationService)
		{
			_logger = logger;
			_reservationService = reservationService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAll()
		{
			 var a = await _reservationService.Get();
			return Ok();
		}
	}
}
