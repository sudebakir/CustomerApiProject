Backend Developer Code Challenge - Customer Management API
About the Project
This project aims to develop a simple RESTful API for managing customer data. The API provides four main endpoints for customer operations: creating, viewing, updating, and deleting customers. The project was developed using .NET Core and Entity Framework Core. 

Architecture
This project uses a Layered Architecture. This structure helps keep the code more understandable, modular, and maintainable. The project is composed of three main layers:

Controller (Presentation Layer): This layer handles HTTP requests and directs them to the appropriate services. The CustomerController contains all customer management endpoints and returns the appropriate responses for user requests. HTTP status codes (such as 200, 400, 404) are set here.

Service (Business Logic Layer): CustomerService contains the business logic. It handles operations like creating, updating, and deleting customers. This layer serves as the bridge between the controller and data access layers. Additionally, validation and error handling are applied in this layer.

Repository (Data Access Layer): This layer manages database interactions and performs database operations using Entity Framework Core. The CustomerRepository class is responsible for handling core database operations such as retrieving, updating, and deleting data, which it then supplies to the business logic layer.

This layered structure ensures each component of the code has a specific responsibility, making the project more maintainable and testable.

Technologies and Tools
.NET Core: Used as the API development platform.
Entity Framework Core: Used as the Object-Relational Mapping (ORM) tool for database operations.
SQL Server: Used as the database.
Dependency Injection: Used to ensure modular and flexible code.
Postman: Used for testing API endpoints.
