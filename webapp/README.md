# Razor page project

This is a personal project based on the Microsoft learn 
documentation [introduction to Razor Pages in ASP.NET Core](https://learn.microsoft.com/en-us/aspnet/core/razor-pages/?view=aspnetcore-8.0&tabs=visual-studio-code) 

## Prerequisites

[.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Project Structure

Once your project is created, you will see the following folder structure:

- **wwwroot**: Contains static files such as CSS, JavaScript, and images.
- **Pages**: Contains Razor pages (e.g., *.cshtml files).
- **Models**: Contains the model classes.
- **Data**: Contains the context classes for database access (currently set to use the in memory database).

## Running the Project

1. Press Ctrl+F5 or click on the Run button to start the project.
2. A browser will open with the address `https://localhost:{PORT}`, showing you the default Razor Pages homepage.
3. Navigate the `https://localhost:{PORT}/Customers` to view the Customer CRUD app.
