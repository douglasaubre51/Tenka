using Microsoft.AspNetCore.Identity;

namespace Tenka.Models{
	public class User : IdentityUser {
		
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		public int HouseholdId { get; set; }
	}
}
