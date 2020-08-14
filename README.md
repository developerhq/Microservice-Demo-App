# C# Microservice Demo App

This example will guide you through the code to build a C# App that works with a MongoDB Server. It demostrates an example of creating microservice(s) in .net core and interacting with external database hosted in a separate container.

This is a ASP.Net Core Web Application. It demonstrates below features - 

1. Add a book
2. Get all books
3. Get book by Id
4. Update book details
5. Delete book by Id

The API can be containerized by creating docker images of the mongo and LibraryAPI web application.

## Get Started

### [Step 1]
Verify if value in MongoDB/Host property is set to "mongo" in appsettings.json file.

### [Step 2]
Run below command in the directory containing docker-compose file -
>> docker-compose up --build

### [Step 3]
Open a mongo client, connect to <vm ip>:27017 to connect to mongo db hosted in container inside the vm.
You will not find the books BookStore database as it gets created when application is fired.

## Available API

### POST

Open a REST client, type in address <vm ip>:8081/api/Library, method as POST, add below json to body and change the type to application/json
```json
{
	"Id":1, //integer
	"ISBN":1, //integer
	"Name":"XYZ", //string
	"Publisher":"ABC", //string
	"Price":500 //integer
}
```
Send request to receive 200 OK in response and the book with Id 1 has been added to the store.

### GET

Open a REST client, type in address <vm ip>:8081/api/Library, method as GET
Send request to get below response
	
```
[{"id":1,"isbn":1,"name":"XYZ","publisher":"ABC","price":500}]
```
  
### GET with ID

Open a REST client, type in address <vm ip>:8081/api/Library/1, method as GET
Send request to get below response
	
```
[{"id":1,"isbn":1,"name":"XYZ","publisher":"ABC","price":500}]
```
### PUT

Open a REST client, type in address <vm ip>:8081/api/Library, method as PUT, add below json to body and change the type to application/json
(updating price from 500 to 1500)

```json
{
	"Id":1, //integer
	"ISBN":1, //integer
	"Name":"XYZ", //string
	"Publisher":"ABC", //string
	"Price":1500 //integer
}
```

Send request to receive 200 OK in response and the book with Id 1 has been updated to the store.

### DELETE

Open a REST client, type in address <vm ip>:8081/api/Library/1, method as DELETE
Send request to receive 200 OK in response and the book with Id 1 has been deleted from the store.

## Contact Us

We built this application with hopes that this will serve as a great starting point for anyone looking to learn about containerization and micro services based design. For any issues that you find, feel free to open a GitHub issue. For commercial enquiries, please reachout to us at hi@developer.sh
