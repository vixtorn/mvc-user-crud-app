ASP.NET Core MVC CRUD Application
This project is a user management system developed using the ASP.NET Core MVC architecture, fully integrated with MSSQL Server. It demonstrates a standard implementation of the Model-View-Controller design pattern and utilizes Entity Framework Core for database operations.

Technical Stack
Framework: .NET 8.0 (ASP.NET Core MVC)

Database: Microsoft SQL Server (MSSQL)

ORM: Entity Framework Core

Frontend: Bootstrap 5, Razor Syntax, HTML5, CSS3

Version Control: Git & GitHub

Core Functionality
Data Visualization: Dynamic fetching and listing of user records from MSSQL.

Delete Operation: Secure removal of user records based on unique identifiers (ID).

Update Operation: Editing existing user data through a structured form interface.

Responsive Design: A mobile-compatible UI built with Bootstrap 5 utility classes.

Project Architecture
Models: Contains data structures such as Kisi.cs that map to database tables.

Views: Includes Razor-based HTML templates like Index.cshtml and Edit.cshtml.

Controllers: Houses logic in HomeController.cs to manage application flow and user requests.

Data: Manages database connectivity via UygulamaDbContext.cs.
