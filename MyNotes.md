
https://learn.microsoft.com/en-us/training/modules/persist-data-ef-core


Add NuGet packages

```
dotnet add package --version 7 Microsoft.EntityFrameworkCore.Sqlite
```

Had to add `--version 7` to all the commands because latest versions are for .net 8

> SQLite uses local database files, so it's probably okay to hard-code the connection string. For network databases like PostgreSQL and SQL Server, you should always store your connection strings securely. For local development, use Secret Manager. For production deployments, consider using a service like Azure Key Vault.

https://learn.microsoft.com/en-us/aspnet/core/security/app-secrets?view=aspnetcore-8.0&tabs=windows

https://learn.microsoft.com/en-us/aspnet/core/security/key-vault-configuration?view=aspnetcore-8.0

Create a db migration from the context

```
dotnet ef migrations add InitialCreate --context PizzaContext
```

## [Change the model and update the database schema](https://learn.microsoft.com/en-us/training/modules/persist-data-ef-core/3-migrations#change-the-model-and-update-the-database-schema)

Changed models and ran this to generate a migration script

```
dotnet ef migrations add ModelRevisions --context PizzaContext
```

Warning about possibly loss of data due to changing the relationship. Be sure the check scripts before running.

```
dotnet ef database update --context PizzaContext
```

## [Reverse-engineer from an existing database](https://learn.microsoft.com/en-us/training/modules/persist-data-ef-core/6-reverse-engineering)

Scaffold models for existing database

```
dotnet ef dbcontext scaffold "Data Source=Promotions/Promotions.db" Microsoft.EntityFrameworkCore.Sqlite --context-dir Data --output-dir Models
```


## Next steps

https://learn.microsoft.com/en-us/training/modules/persist-data-ef-core/7-summary