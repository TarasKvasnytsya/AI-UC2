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
				switch (e.StripeError.Type)
				{
					case "card_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					case "api_connection_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					case "api_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					case "authentication_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					case "invalid_request_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					case "rate_limit_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					case "validation_error":
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;

					default:
						// Unknown Error Type
						Console.WriteLine("Code: " + e.StripeError.Code);
						Console.WriteLine("Message: " + e.Message);
						break;
				}

				return BadRequest(e.Message);
			}			
		}
	}
}
