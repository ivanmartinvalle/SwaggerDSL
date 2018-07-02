# SwaggerDSL
Design-time Swagger generation via C#

## Background
Swagger is a great tool for documenting an API, but is tedious to manually write. This tool generates Swagger using concepts that most developers already know: defining HTTP requests and responses. It is nothing more than a convenient setup of [Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore).

Use cases:

 - quickly generating Swagger for an unimplemented API
 - quickly generating Swagger for an API implemented in a language where it is difficult to generate Swagger, e.g. Javascript

## Adding to a Project
```sh
cd your-project-directory
git clone this_repo
rm -rf this_repo/.git
```

The idea is that your Swagger generation code lives alongside your application code.

## Defining an API
 - Create a class named after your API, e.g. Products
 - Add the `ApiController` attribute
 - Add the `Route` attribute, e.g. `Route("products")`. See [Attribute Routing](https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing?view=aspnetcore-2.1#attribute-routing) for usage
 - For each API verb
	- Add the appropriate `Http{VERB}` attribute, e.g `HttpGet`
	- Add a `Route` attribute if the API route differs from the class, e.g. `Route("{id}")`
	- Define the request and response parameters

See [Products.cs](Products.cs) for an example, and [the Swashbuckle documentation](https://github.com/domaindrivendev/Swashbuckle.AspNetCore) for advanced usage.

## Exploring an API
Prerequsite: [.NET Core SDK](https://www.microsoft.com/net/download)

### Via UI
```sh
dotnet run 
```

or debug in VS Code with F5

Swagger UI will be available at `http://localhost:5000/swagger`

### Via CLI
```sh
dotnet swagger tofile bin/Debug/netcoreapp2.1/SwaggerDSL.dll v1
```
