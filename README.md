# _National Parks Api_

#### _Search and Manage National Park Data, {11/1/2019}_

#### By _**Devin Cooley**_

## Description

_An Api designed to allow the administrator to Display, Create, Delete, and Update national park data._

## Specifications

| Spec                      |Method|
|:---------------------------|:-------------|
|Allows user to search a list of national park data.|Get (parameter:name/location/description) |
|Allows user to create a new park object|Post|
|Allows user to delete a park object|Delete|
|Allows a user to update a park object|Patch|
|Allows user to display a certain park.| Get{id}|

## Setup/Installation Requirements

_Clone this repository from GitHub. You must create an appsettings.json file in the project directory, then place the following text in your appsettings.json file:  

{  
    {  
  "AllowedHosts": "*",  
  "ConnectionStrings": {  
    "DefaultConnection": "Server=localhost;Port=3306;database=national_parks_api;  uid=root;pwd=Davin098#;"  
  }  
}

You may make api calls to this api from any client setup to do so. Example queries for each endpoint follow:
|Funtion                     |Parameter       | ExampleRequest     |
|:---------------------------|:-------------|:--------------|
|Post|Create Object in body of request with literal object | http://localhost:5000/api/parks/{id}|
|Get|{id}|http://localhost:5000/api/parks/{id}|
|Patch|{id}, Include literal object containing changes|http://localhost:5000/api/parks/{id}|
|Delete|{id}|http://localhost:5000/api/parks/{id}
|Get|"name" and/or "location" and/or "description"|http://localhost:5000/api/Parks/?name=EverGlades|

## Known Bugs

_There are no known bugs at this time._

## Support and contact details

_Send any questions or comments to Devin Cooley at dcooley1350@gmail.com._

## Technologies Used

_This program was written using HTML, C# and the .NET Framework. MySql Entity and Identity were implemented. The application is viewed in a web browser or other api capable client._

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Devin Cooley_**