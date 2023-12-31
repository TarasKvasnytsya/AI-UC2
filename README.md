Application Description
This is a .NET Core Web API application that is designed to interact with Stripe's API for transaction and balance inquiries. The application contains two controllers: the BalanceTransactionsController and the StripeController. The BalanceTransactionsController is responsible for retrieving a list of balance transactions using Stripe's API. It provides options to paginate results by specifying the page and the page size, thus enabling you to view specific subsets of the list based on the supplied query parameters.

The StripeController, on the other hand, is responsible for retrieving the balance details of a Stripe account. By calling the appropriate endpoint, you can get an overview of the balance in your Stripe account. This Web API is an excellent start for creating a more comprehensive payment processing system using the Stripe API. The Web API is designed to be simple and efficient, providing direct interaction with the Stripe API and relaying the information back to the user in a clear and concise format.

Running the Application Locally
To run the application on your local machine, follow these steps:

Clone the repository to your local machine.
Open the solution file in Visual Studio or any .NET IDE you prefer.
Before running, ensure to replace "sk_test_4eC39HqLyjWDarjtT1zdp7dc" with your Stripe secret key in the StripeController. This is critical for authenticating your requests with the Stripe API.
Run the application. Depending on your setup, you may need to select "IIS Express" or "Kestrel" as the run target in Visual Studio.
The application should be accessible at https://localhost:<port>/ where the <port> is specific to your configuration (commonly 5001 for HTTPS).
Example URLs for API Usage
Here are two examples on how to use the provided endpoints:

To retrieve the balance of your Stripe account: Navigate to the following URL on your localhost -

https://localhost:<port>/api/Stripe/GetBalance

This will return the balance details of your Stripe account.

To retrieve the list of balance transactions: You can use this URL -

https://localhost:<port>/api/BalanceTransactions?page=1&pageSize=10

This will return the first ten balance transactions from your Stripe account. You can modify the page and pageSize parameters to suit your needs.