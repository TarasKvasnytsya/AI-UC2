using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace MyWebApiProject.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BalanceTransactionsController : ControllerBase
	{
		[HttpGet]
		public async Task<IActionResult> GetBalanceTransactions([FromQuery] int page = 1, [FromQuery] int pageSize = 10)
		{
			try
			{
				var service = new BalanceTransactionService();

				var options = new BalanceTransactionListOptions()
				{
					Limit = pageSize,
					StartingAfter = (page > 1) ? ((page - 1) * pageSize).ToString() : null
				};

				var balanceTransactions = await service.ListAsync(options);

				return Ok(balanceTransactions);
			}
			catch (StripeException ex)
			{
				return BadRequest(new { message = ex.Message });
			}
			catch (Exception ex)
			{
				// Log the exception...
				return StatusCode(500, new { message = $"An error occurred while retrieving balance transactions. {ex.Message}" });
			}
		}
	}
}
