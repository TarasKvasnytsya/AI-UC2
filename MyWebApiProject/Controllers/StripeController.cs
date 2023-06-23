using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace MyWebApiProject.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StripeController : ControllerBase
	{
		[HttpGet]
		[Route("api/Stripe/GetBalance")]
		public IActionResult GetBalance()
		{			
			try
			{
				var service = new BalanceService();
				Balance balance = service.Get();

				return Ok(balance);
			}
			catch (StripeException e)
			{
				Console.WriteLine("Code: " + e.StripeError.Code);
				Console.WriteLine("Message: " + e.Message);

				return BadRequest(e.Message);
			}			
		}
	}
}
