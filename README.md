# React-Angular With ASP.NET Core Web API

--- ---

## Steps that needs to be taken

- Install mongodb Driver on the ASP.Net Core Web API

--- ---

## Settings for MongoDb with ASP.Net Core

- Add Connection string as follows

```json
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "MongoDatabase": {
    "ConnectionString": "mongodb://localhost:[portNumber]",
    "DatabaseName": "[Database Name]",
    "CollectionName":  "[Table Name]"
  }
}

```

- Create Configration class as follows

```c#
namespace MongDbWebAPI.Configration
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = string.Empty;
        public string DatabaseName { get; set; } = string.Empty;    
        public string CollectionName { get; set; } = string.Empty;
    }
}

```

- Add connection string to **_program.cs_**

```c#
builder.Services.Configure<DatabaseSettings>(builder.Configuration.GetSection("MongoDatabase"));
```

--- ---