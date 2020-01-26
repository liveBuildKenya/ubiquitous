# Example .Net Core Web Api

This is a web api built on .net core 3.1.

It Implements the following:

1. Uses EFCore to run on sql server database engine.
2. Seperates concerns by breaking project down to parts.
3. Uses NLog for logging.
4. Uses Autofac for dependency injection.
5. Uses AutoMapper for mapping POCO classes and API models.
6. Uses xUnit to test services.

The application is seperates to parts as follows:

1. AppSeed - Contains the core classes shared across solution (netstandard2.0)
2. AppDomain - Contains the domain models and mappings to the database (netcoreapp3.1)
3. AppServices - Contains the services that connect to domain performing CRUD actions (netcoreapp3.1)
4. AppApi.Framework - Contains service collection extensions.
5. AppApi - Contains the web API.
6. AlbumService.Tests - Contains the tests classes.

# References
* [AspNetCore Documentation](https://docs.microsoft.com/en-us/aspnet/core/?view=aspnetcore-3.1)
* [EFCore Documentation](https://docs.microsoft.com/en-us/ef/)
