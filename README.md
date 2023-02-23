# NotissimusTestProject
ASP.NET MVC Application

## Technologies
- ASP.NET Core 7.0
- Entity Framework 8.0
- MSSQL Server (docker image from Docker Hub)
- NUnit
- Bootstrap
- Docker 4.16.3

## How to run
### Before run
#### 1. Creating configuration files
Take note that before trying to start the app, you need to change configuration files 'DbSettings.json' in [Tests](/Tests/JsonOptions/DbSettings.json) and [Web](/Web/JsonOptions/DbSettings.json)  and specify your connection parameters. 

File contents of 'DbSettings.json' in Web:
```
{
  "DbConnectionSettings": 
  {
    "Server": "localhost,1433",
    "Database": "mydb",
    "UserId": "userId",
    "Password": "12345",
    "TrustServerCertificate": true
  }
}
```

**Notice** that the first one **contains the key value** and the second **should not**. File contents of 'DbSettings.json' in Tests:
```
{
  "Server": "localhost,1433",
  "Database": "mydb",
  "UserId": "userId",
  "Password": "12345",
  "TrustServerCertificate": true
}
```

#### 2. Connecting to MSSQL Server
MSSQL Server docker image [here](https://hub.docker.com/_/microsoft-mssql-server). 

Download image:

```
docker pull mcr.microsoft.com/mssql/server
```

Create container and start it:
```
docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server:2022-latest
```


### Run
Build:

```
dotnet build
```

Run web:
```
dotnet run --project Web/Web.csproj
```

Run tests:
```
dotnet test
```
