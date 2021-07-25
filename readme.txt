The solution contains 9 projects in total:
==========================================

1. GlobalKinetic.Database
This is a visual studio sql server database project that will be used to publish the database.

2. GlobalKinetic.Authentication
This is the authentication layer by which users can added to the system and that generated a
JWT token to be used for the CoinJar service. This is a .NET Core WebAPI.

3. GlobalKinetic.JWTHelper
This is the service layer for the Authentication WebAPI.

4. GlobalKinetic.CoinJar
This is the .NET Core WebAPI for the CoinJar classes.

5. GlobalKinetic.Services
Services layer for the CoinJar WebAPI and also Authenticaiton WebAPI

6. GlobalKinetic.Repository
This is the repositority layer for the services

7. GlobalKinetic.DataHelper
This is the data access helper foe the repository layer

8. GlobalKinetic.Models
The interfaces, entities, models that is used in the system

9. GlobalKinetic.WebAPITests
This is the Unit test application for the CoinJar WebAPI

How to run the application:
===========================

1. Build Solution
2. Setup multiple startup application and choose GlobalKinetic.Authenticaion and GlobalKinetic.CoinJar
3. Use Swagger from GlobalKinetic.Authentication and generate a token. 
4. Switch to CoinJar and authenticate with token
5. Do the AddCoin, Reset and GetTotalAmount WebApi Calls. 