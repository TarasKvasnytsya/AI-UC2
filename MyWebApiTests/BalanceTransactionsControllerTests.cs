using FakeItEasy;
using MyWebApiProject.Controllers;
using Stripe;
using Shouldly;

namespace MyWebApiTests
{
	[TestClass]
	public class BalanceTransactionsControllerTests
	{
		private BalanceTransactionsController _sut = null!;

		[TestInitialize]
		public void SetUp()
		{			
			_sut = new BalanceTransactionsController();
		}

		[TestMethod]
		public async Task GetBalanceTransactions_ReturnsOk_WhenCalledWithValidArgsAsync()
		{
			// Arrange
			var _fakeservice = A.Fake<BalanceTransactionService>();
			A.CallTo(() => _fakeservice.ListAsync(A<BalanceTransactionListOptions>._, default, default))
				.Returns(Task.FromResult<StripeList<BalanceTransaction>?>(null));

			// Act
			var result = await _sut.GetBalanceTransactions();

			// Assert
			result.ShouldNotBeNull();
		}
	}
}