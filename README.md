# _National Parks Api_

#### _Search and Manage National Park Data, {11/1/2019}_

#### By _**Devin Cooley**_

## Description

_An Api designed to allow the administrator to Display, Create, Delete, and Update national park data._

## Specifications

| Spec                      |Method|
|:---------------------------|:-------------|
|Requires/Allows a user to register|Post|
|Requires/Allows a user to login|Post|
|Allows user to search a list of national park data.|Get (parameter:name/location/description) |
|Allows user to create a new park object|Post|
|Allows user to delete a park object|Delete|
|Allows a user to update a park object|Patch|
|Allows user to display a certain park.| Get{id}|

## Setup/Installation Requirements

_Clone this repository from GitHub. You must create an appsettings.json file in the project directory, then place the following text in your appsettings.json file:_  

{  
    {  
  "AllowedHosts": "*",  
  "ConnectionStrings": {  
    "DefaultConnection": "Server=localhost;Port=3306;database=national_parks_api;  uid=root;pwd=epicodus;"  
  }  
}  
_In the project directory, run "dotnet restore" to restore all necessary files._
_In the project directory, run "dotnet ef database update" to create the neccessary database._
_In the project directory, run "dotnet run" to start the application."

_Your first 2 calls to the api will need to be registering and logging in. You will not be able to use any other function of the api if you do not successfully login._   

Registration: _Make a post request to the address http://localhost:5000/register. In the body of the post request, in JSON format, place a username and password in the following format:  

{  
  "Email": "YourEmail",  
  "Password": "YourPassword"  
}    
**Password must be at least 5 characters but that is the only requirement**  
_If registration is successful you will recieve your username back in the body of the response._  

Log In: _Make a Post request to the address http://localhost:5000/login. In the body of the request, in JSON format, place your username and password in the following format:_  

{  
	"UserName" : "dcooley1350",  
	"Password" : "password"  
}  

**If Login is successful, you will recieve your token in return, and the time of expiration.**

_You may make api calls to this api from any client setup to do so. Example queries for each endpoint follow:_
|Function                     |Parameter       | ExampleRequest     |
|:---------------------------|:-------------|:--------------|
|Post|Insert into body email and password|http://localhost:5000/register|
|Post|Insert into body username and password|http://localhost:5000/login|
|Post|Create Object in body of request with literal object | http://localhost:5000/api/parks/{id}|
|Get|{id}|http://localhost:5000/api/parks/{id}|
|Patch|{id}, Include literal object containing changes|http://localhost:5000/api/parks/{id}|
|Delete|{id}|http://localhost:5000/api/parks/{id}
|Get|"name" and/or "location" and/or "description"|http://localhost:5000/api/Parks/?name=EverGlades|

## Swagger

_This application is equipped with Swagger. go to "http://localhost:5000/swagger/index.html" in your browser while running the application to explore swagger. Major Swag fa sho._
## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Send any questions or comments to Devin Cooley at dcooley1350@gmail.com._

## Technologies Used

_This program was written using HTML, C# and the .NET Framework. MySql Entity and Identity were implemented. The application is viewed in a web browser or other api capable client. This application is swagger enabled_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Devin Cooley_**