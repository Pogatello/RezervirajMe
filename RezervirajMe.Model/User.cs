using Microsoft.AspNet.Identity.EntityFramework;

namespace RezervirajMe.Model
{
	public class User : IdentityUser
	{
		public bool IsActive { get; set; }

		public string Username { get; set; }

		public string DisplayName { get; set; }
	}
}
