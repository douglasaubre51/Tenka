using Tenka.Models;

namespace Tenka.Data{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
		: IdentityDbContext<User>(options)
	{
		DbSet<Household> Households { get; set; }
		DbSet<WaterTank> Households { get; set; }
		DbSet<Household> Households { get; set; }
	}
}
