using Microsoft.AspNetCore.Mvc;

using Tenka.Dtos;

namespace Tenka.Controllers{
	[ApiController] [Route("/api/[controller]")] public class LeakController{
		
		[HttpPost("/leak")] public IResult TriggerValveShutoff(
			[FromBody] ValveShutoffDto dto
			)
		{
			try{
				
				return Results.Ok();	
			}
			catch(Exception ex){
				Console.WriteLine("TriggerValveShutoff error: "+ ex);
				return Results.InternalServerError();
			}
		}

	}
}
