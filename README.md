# FilmApp

A Windows Forms desktop application for managing a movie/film catalog, built with a layered (N-tier) architecture in .NET 8.

## Architecture

The solution is split into four projects, following a classic layered architecture:

| Project | Responsibility |
|---|---|
| `FilmApp.Entities` | Domain models (`Film`) and base entity contracts (`IEntity`). |
| `FilmApp.DataAccess` | Data access layer. Defines repository abstractions (`IEntityRepository<T>`, `IFilmDal`) with an Entity Framework Core implementation (`EFFilmDal`, `FilmAppContext`) and an alternate NHibernate implementation (`NFilmDal`). |
| `FilmApp.Business` | Business/service layer (`IFilmService`, `FilmManager`) sitting between the UI and the data access layer. |
| `FilmApp.FormsUi` | Windows Forms UI (`Form1`, `FilmDetailForm`) that lists, searches, adds, edits, and deletes films. |

## Tech stack

- .NET 8 / C# (Windows Forms)
- Entity Framework Core 8 (SQL Server provider)
- NHibernate (alternate data access implementation)
- SQL Server

## Getting started

### Prerequisites

- .NET 8 SDK
- Windows (Windows Forms requires `net8.0-windows`)
- SQL Server (local or remote instance)

### Configuration

Update the connection string in `FilmApp.DataAccess/appsettings.json` to point to your SQL Server instance:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=StokFlow;Trusted_Connection=True;TrustServerCertificate=True"
  }
}
```

### Database

EF Core migrations are located in `FilmApp.DataAccess/Migrations`. Apply them with:

```powershell
dotnet ef database update --project FilmApp.DataAccess
```

### Build & run

```powershell
dotnet build FilmApp.sln
dotnet run --project FilmApp.FormsUi
```

## Features

- List all films in a data grid
- Search/filter films by title
- Add, edit, and delete films
