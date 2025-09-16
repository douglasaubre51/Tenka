using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Tenka.Models{
    public class Household{

	[Key] public int HouseholdId { get; set; }

	public int UserId { get; set; }

	public int WaterTankId { get; set; }

    }
}

