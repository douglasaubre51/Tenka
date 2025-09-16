using Microsoft.AspNetCore.Mvc;

using Tenka.Dtos;
using Tenka.Data;
using Tenka.Models;

namespace Tenka.Controllers{
	[ApiController] public class WaterLevelController(ApplicationDbContext _context){
		
		[HttpGet("/set/{level}")] public IResult SetWaterLevel(
			int level
			)
		{
			try{
				
				_context.WaterTanks.Add(new WaterTank{ WaterLevel = level });
				_context.SaveChanges();

				return Results.Ok();	
			}
			catch(Exception ex){
				Console.WriteLine("TriggerValveShutoff error: "+ ex);
				return Results.InternalServerError();
			}
		}

		[HttpGet("/get")] public IResult GetWaterLevel()
		{
			try{
				var tank = _context.WaterTanks.OrderBy(e=>e).Last();

				return Results.Ok(tank.WaterLevel);	
			}
			catch(Exception ex){
				Console.WriteLine("TriggerValveShutoff error: "+ ex);
				return Results.InternalServerError();
			}
		}

	}
}
