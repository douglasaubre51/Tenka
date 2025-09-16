using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tenka.Models{
    public class Household{

	[Key] public int HouseholdId;

	[ForeignKey("UserId")] public User User { get; set; }

	public List<WaterTank> WaterTanks { get; set; }

    }
}

