# C# Microservice Demo App

This is a demonstration project to showcase C# application built with microservices pattern. This is a ASP.Net Core Web Application, and uses MongoDB as the backing store. It demonstrates below features

1. Add a book
2. Get all books
3. Get book by Id
4. Update book details
5. Delete book by Id

## Get Started

You can use the docker-compose file to get the project running with a single command. Run the below command in base directory of this project, locally.

```sh
docker-compose up --build
```

## Available API

You can use a API tool like [Postman](https://www.postman.com) to consume the API expose by this application.

### POST

Address: <vm ip>:8081/api/Library
Method: POST
Body:
```json
{
	"Id":1,
	"ISBN":1,
	"Name":"XYZ",
	"Publisher":"ABC",
	"Price":500
}
```
This creates a new book entry in MongoDB, with ID `1`.

### GET

Address: <vm ip>:8081/api/Library
Method: GET
	
```json
[{"id":1,"isbn":1,"name":"XYZ","publisher":"ABC","price":500}]
```
This returns all the current book entries.

### GET with ID

Address: <vm ip>:8081/api/Library/1
Method: GET
	
```
[{"id":1,"isbn":1,"name":"XYZ","publisher":"ABC","price":500}]
```
This returns all the book with id = 1.

### PUT

Address: <vm ip>:8081/api/Library
Method: PUT
Body:
```json
{
	"Id":1, 
	"ISBN":1,
	"Name":"XYZ",
	"Publisher":"ABC", 
	"Price":1500
}
```
This updates the price from 500 to 1500.

### DELETE

Address: <vm ip>:8081/api/Library/1
Method: DELETE

This deletes the book with id = 1

## Contact Us

We built this application with hopes that this will serve as a starting point for anyone looking to learn about containerization and micro services based design. For any issues that you find, feel free to open a GitHub issue. For commercial enquiries, please reachout to us at hi@developer.sh
