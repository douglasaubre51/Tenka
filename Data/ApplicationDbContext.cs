using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using Tenka.Models;

namespace Tenka.Data{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
		: DbContext(options)
	{
		public DbSet<Household> Households { get; set; }
		public DbSet<WaterTank> WaterTanks { get; set; }
	}
}
