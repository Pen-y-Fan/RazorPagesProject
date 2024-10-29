# Tutorial: Get started with Razor Pages in ASP.NET Core

Based on the 
tutorial [Get started with Razor Pages in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start?view=aspnetcore-8.0&tabs=visual-studio-code)

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- 
- Rider, VS Code or Visual Studio

## Installation

From the command line build the project

```shell
dotnet dev-certs https --trust
dotnet build
```

Migrate the database using the command-line interface (CLI) tools for EF Core

```shell
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet ef database update
```

Run the project

```shell
dotnet watch run
```