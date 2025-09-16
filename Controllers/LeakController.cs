namespace Tenka.Controllers{

	[ApiController("/api/[controller]")] public class LeakController{
		
		[HttpPost("/leak")] public ActionResult TriggerValveShutoff(
			[FromBody] ValveShutoffDto dto
			)
		{
			try{
			}
			catch(Exception ex){
				Console.WriteLine("TriggerValveShutoff error: "+ ex);
				return InternalServerError();
			}
		}
	}
}
