# Portfolio API — WPFW Opdracht 3

## Beschrijving

Voor WPFW opdracht 3 heb ik een backend gemaakt voor mijn portfolio. Ik gebruik ASP.NET Core Web API (.NET 10), EF Core en SQL Server.

Met de API kan ik projecten en blogposts toevoegen, ophalen, aanpassen en verwijderen ->CRUD .

## Technologieën

- C# / .NET 10
- ASP.NET Core Web API
- Entity Framework Core 10
- SQL Server
- Swagger UI
- Docker Desktop

## Architectuur

Mijn API heeft een paar lagen:

- **Controllers:** krijgen HTTP-verzoeken en sturen antwoorden terug.
- **Services:** doen de logica en de database-acties.
- **Data:** `PortfolioDbContext` regelt de toegang tot SQL Server via EF Core.
- **Models:** bevatten de entiteiten `Project` en `Blogpost`.
- **DTOs:** bepalen welke gegevens binnenkomen en welke teruggaan.

In `Program.cs` koppel ik de services via dependency injection.

## API-endpoints

### Projects

| Methode | Endpoint             | Functie                |
| ------- | -------------------- | ---------------------- |
| GET     | `/api/projects`      | Alle projecten ophalen |
| GET     | `/api/projects/{id}` | Eén project ophalen    |
| POST    | `/api/projects`      | Project toevoegen      |
| PUT     | `/api/projects/{id}` | Project aanpassen      |
| DELETE  | `/api/projects/{id}` | Project verwijderen    |

### Blogposts

| Methode | Endpoint              | Functie                |
| ------- | --------------------- | ---------------------- |
| GET     | `/api/blogposts`      | Alle blogposts ophalen |
| GET     | `/api/blogposts/{id}` | Eén blogpost ophalen   |
| POST    | `/api/blogposts`      | Blogpost toevoegen     |
| PUT     | `/api/blogposts/{id}` | Blogpost aanpassen     |
| DELETE  | `/api/blogposts/{id}` | Blogpost verwijderen   |

## Benodigdheden

- .NET 10 SDK
- Docker Desktop met SQL Server
- EF Core CLI (`dotnet-ef` versie 10)

## Database instellen

Ik gebruik SQL Server via Docker op `127.0.0.1,1434`.

De connectionstring staat lokaal in .NET User Secrets onder:

`ConnectionStrings:PortfolioDatabase`

Zet je eigen connectionstring met je eigen inloggegevens. Wachtwoorden horen niet op GitHub.

Ga in de terminal naar `PortfolioApi` en voer uit:

```bash
dotnet restore
dotnet ef database update
```

EF Core voert de migratie `InitialCreate` uit en maakt de tabellen `Projects` en `Blogposts` aan.

## API starten

Ga naar de map `PortfolioApi` en typ:

```bash
dotnet run
```

De API draait lokaal op:

`http://localhost:5180`

Open Swagger op:

`http://localhost:5180/swagger`

De poort kan per configuratie anders zijn.

## API testen

Ik test de endpoints via Swagger in deze volgorde:

1. **POST:** gegevens toevoegen.
2. **GET:** gegevens ophalen.
3. **PUT + GET:** gegevens aanpassen en controleren.
4. **Herstart + GET:** controleren of de gegevens blijven staan.
5. **DELETE + GET:** verwijderen en kijken of er `404 Not Found` verschijnt.

## GitHub

Mijn code en commitgeschiedenis staan op:

https://github.com/Sofia-bit-2025/wpfw-portfolio-sofia.git
