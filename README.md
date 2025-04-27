# 🕹️ Game Store Web App 🕹️

This is a full-stack web application built with **ASP.NET Core** and **C#**. It consists of a back-end REST API integrated with a pre-built front-end. The app provides full CRUD functionality for managing a game store, leveraging key modern development practices and technologies to ensure scalability, maintainability, and performance.

This web app demonstrates key **full-stack development skills** using **ASP.NET Core**, including building and structuring a **RESTful API**, working with **data transfer objects**, and integrating the back-end with a pre-built front-end. The project also emphasizes best practices in software design, such as **dependency injection**, **asynchronous programming**, and using **Entity Framework Core** for data access.

## Key Concepts & Technologies Used

- **REST API**: Developed a RESTful API to handle HTTP requests and serve as the back-end of the web app, ensuring a robust and scalable architecture.
- **Data Transfer Objects (DTOs)**: Applied DTOs to facilitate data exchange between layers, promoting loose coupling and cleaner code.
- **CRUD Endpoints**: Designed and implemented comprehensive CRUD endpoints for managing games in the store using **Entity Framework Core (EF Core)**.
- **Entity Framework Core (EF Core)**: Used EF Core as the ORM for data access, enabling efficient database interactions and automated migrations.
- **Extension Methods**: Applied custom extension methods to improve code reusability and readability across the project.
- **Route Groups**: Organized API routes into logical groups to improve the structure and maintainability of the codebase.
- **Dependency Injection & Inversion of Control**: Implemented Dependency Injection and Inversion of Control to ensure loose coupling and manage service lifetimes (Scoped, Singleton, Transient).
- **Asynchronous Programming**: Applied asynchronous programming to the API endpoints, ensuring non-blocking operations and enhancing the app's performance and scalability.
- **API Integration with Front-End**: Integrated the API with a pre-built front-end, enabling smooth communication between the front-end and back-end systems.

## API Endpoints

### Games

- **GET http://localhost:5099/games**: Retrieve a list of all games in the store.
- **GET http://localhost:5099/games/{id}**: Retrieve details of a specific game by its ID.
- **POST http://localhost:5099/games**: Add a new game to the store.
- **PUT http://localhost:5099/games/{id}**: Update an existing game by ID.
- **DELETE http://localhost:5099/games/{id}**: Delete a game from the store.

### Example Request

```bash
POST http://localhost:5099/games
Content-Type: application/json

{
    "name": "Street Fighter II",
    "genreId": 1,
    "price": 19.99,
    "releaseDate": "1922-07-15"
}
```

### Example Response
```bash
GET http://localhost:5099/games/1
Content-Type: application/json

{
    "id": 1,
    "name": "Street Fighter II",
    "genre": "Fighting",
    "price": 19.99,
    "releaseDate": "1922-07-15"
}
```

## How to Run the Project

To run the **back-end** and **front-end**, you need to execute the following commands from the root of the project:

### Running the Back-End API

```bash
dotnet run --project GameStore.Api/GameStore.Api.csproj
```

### Running the Front-End

```bash
dotnet run --project GameStore.Frontend/GameStore.Frontend.csproj
```

Make sure to run both commands in separate terminal windows to keep both the back-end API and the front-end running simultaneously.