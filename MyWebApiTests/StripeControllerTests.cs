using FakeItEasy;
using MyWebApiProject.Controllers;
using Shouldly;
using Stripe;

namespace MyWebApiTests
{
	[TestClass]
	public class StripeControllerTests
	{
		private StripeController _sut = null!;

		[TestInitialize]
		public void SetUp()
		{
			_sut = new StripeController();
		}

		[TestMethod]
		public void GetBalanceReturnsOkWhenCalledWithValidArgsAsync()
		{
			// Arrange
			var _fakeservice = A.Fake<BalanceService>();
			A.CallTo(() => _fakeservice.Get(default))
				.Returns(new Balance());

			// Act
			var result = _sut.GetBalance();

			// Assert
			result.ShouldNotBeNull();
		}
	}
}
