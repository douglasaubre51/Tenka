using System.ComponentModel.DataAnnotations;

namespace Tenka.Models{
	public class User{
		
		[Key] public int UserId { get; set; }
		
		public string EmailId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		
		[ForeignKey] public Household Household { get; set; }
	}
}
