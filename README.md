Deployment details:

WebAPI endpoint: (Swagger interface)
https://rebtelsamplewebapi.azurewebsites.net/swagger/ui/index

Solution: WebApi\Rebtel.UserManagement.WebApi.sln

 
WCF endpoints: Hosted in IIS (Azure app service with no security (authentication) or SSL for this prototype)
http://rebtelsamplewcf.azurewebsites.net/UserManagement.svc
http://rebtelsamplewcf.azurewebsites.net/SubscriptionManagement.svc

Solution: WCF\Rebtel.UserManagement.WCFService.sln

Technical overview:
1. The WebAPI/WCF follows Domain Driven Design in conjunction with CQRS (Command Query Responsibility Segregation).
2. Microsoft Unity is used as the dependency injection framework (Inversion of Control) so that the each layer is loosely coupled on the dependencies and also easily unit testable.
3. Entity framework is used as the ORM. In this prototype, code first approach is followed and Azure SQL database is used as the data store.
4. Async/Await is used wherever applicable for the overall performance efficiency of the web application.
5. Common assembly for logging is used in both WebAPI and WCF solutions to illustrate the usage of reusable framework.


Prototype description:

Implement Web Api for creating user and his phone subscriptions.
The logic for getting/writing data from/to DB should be in a separate WCF service.
Database can be MS SQL Server or MS SQL Server Express.

Client will POST/GET/PUT/DELETE data to Web Api, Web Api will connect to WCF service to write/read data from database.

User:

Base-URI will be /users

API should do the following:

Get all users (GET -> /users)
Get current user (GET -> /users/some-url-friendly-identifier)
Create user (POST -> /users)
Add subscription to user (PUT -> /users/subscriptionId)
Delete user (DELETE -> /users/some-url-friendly-identifier)


JSON-structure for user resource:

{
  "id":"some-url-friendly-identifier",
  "firstname":"First name",
  "lastname":"Last name",
  "email":"email",
  "subscriptions": [
		{
		  "id":"2712e86a-d519-48af-b50b-194e9a2102de",
		  "price":24.0,
		  "totalPriceIncVatAmount":30.0,
		  "callminutes":50
		},
		{
		  "id":"4712e86a-d519-48af-b50b-194e9a2102dd",
		  "price":14.0,
		  "priceIncVatAmount":20.0,
		  "callminutes":20
		},
  ],
	"totalPriceIncVatAmount":50.0,  //30 + 20
	"totalcallminutes":70  // 50 + 20
}

totalPriceIncVatAmount is a summary of the price for all subscriptions
totalcallminutes is a summary of call minutes for all subscriptions


Subscription

Base-URI will be /subscriptions

API should do the following:

Get all subscriptions (GET -> /subscriptions)
Get current subscription (GET -> /subscriptions/some-url-friendly-identifier)
Create subscription (POST -> /subscriptions)
Update subscription data such  (PUT -> /subscriptions/some-url-friendly-identifier)
Delete subscription (DELETE -> /subscriptions/some-url-friendly-identifier)

JSON-structure for subscription resource:

{
  "id":"2712e86a-d519-48af-b50b-194e9a2102de",
  "name":"50 min deal",
  "price":24.0,
  "priceIncVatAmount":30.0,
  "callminutes":50
}
