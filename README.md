# Entity Framework Core PostgreSQL Example

## Project Overview
Simple Windows Forms application demonstrating basic database operations using Entity Framework Core with PostgreSQL.
- Add, view, delete database records
- Simple Windows Forms interface
- PostgreSQL database integration

## Requirements
- Visual Studio
- .NET Core 8
- Docker
- PostgreSQL

## Setup Steps
1. Clone the repository
2. Install required NuGet packages
   - Npgsql.EntityFrameworkCore.PostgreSQL
   - Microsoft.EntityFrameworkCore.Design
   - Microsoft.EntityFrameworkCore.Tools

3. Start PostgreSQL Docker container
```bash
docker run --name postgres-db -e POSTGRES_PASSWORD=password -p 5432:5432 -d postgres
```

4. Update connection string in `AppDbContext.cs`
```csharp
optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=yourdb;Username=postgres;Password=password");
```

5. Create database migrations
```powershell
Add-Migration InitialCreate
Update-Database
```

## Project Structure
- `Models/`: Database entity classes
- `Data/`: Database context
- `Forms/`: User interface windows
- `Migrations/`: EF Core migration files

