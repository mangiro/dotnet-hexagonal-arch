# .NET Hexagonal Architecture API Example
*The lazy version*

## Requirements

- .NET sdk/runtime [8.0](https://learn.microsoft.com/pt-br/dotnet/core/whats-new/dotnet-8)
- [dotnet-ef](https://learn.microsoft.com/pt-br/ef/core/cli/dotnet) tool

## Config

```bash
# start database instance
$ docker-compose up -d

# apply migrations
$ dotnet-ef database update -p Infra.Database.PostgreSQL -s Api
```

## Running the app

```bash
$ dotnet run --project Api
```
Go to http://localhost:5263/swagger
