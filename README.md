# WEBAPI Skeleton

Simple RESTful API built with ASP.NET Core 3.1.

Web api skeleton (.Net Core 3.1)

## Frameworks and Libraries
- [ASP.NET Core 3.1](https://docs.microsoft.com/pt-br/aspnet/core/?view=aspnetcore-3.1);
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) (for data access);
- [AutoMapper](https://automapper.org/) (for mapping resources and models);
- [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle) (API documentation).

## How to Test

First, install [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1). Then, open the terminal or command prompt at the API root path and run the following commands, in sequence:

```
dotnet restore
dotnet run
```

Navigate to ```https://localhost:5001/swagger``` to check the API documentation.

To test all endpoints, you'll need to use a software such as [Postman](https://www.getpostman.com/).