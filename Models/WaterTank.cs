using System.ComponentModel.DataAnnotations;

namespace Tenka.Models{
	public class WaterTank{
		
		[Key] public int WaterTankId { get; set; }

		public bool Shutoff { get; set; }
	}
}
