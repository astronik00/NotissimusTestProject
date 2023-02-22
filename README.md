# NotissimusTestProject
ASP.NET MVC Application

## Technologies
- ASP.NET Core 7.0
- Entity Framework 8.0
- MSSQL Server (used Docker container from Docker Hub)
- NUnit
- Bootstrap
- Docker 4.16.3

## How to run
### Before run
#### 1. Creating configuration files
Take note that before trying to start app, you need to create folders 'JsonOptions' in Web Project, than
create configuration files 'DbSettings.json' and 'XmlSettings.json'. 

Content of DbSettings.json:
```json
{
  "DbConnectionSettings": {
    "Server": "Your Server",
    "Database" : "Your Database",
    "UserId": "Your UserId",
    "Password": "Your Password",
    "TrustServerCertificate": true
  }
}
```

Content of XmlSettings.json:
```json
{
  "XmlReadFileSettings": {
    "Url": "http://partner.market.yandex.ru/pages/help/YML.xml"
  }
}
```

If you want to run Unit tests, than create the same folder and files but without keys "DbConnectionSettings" and "XmlReadFileSettings" as below:
```json
{
  "Server": "Your Server",
  "Database" : "Your Database",
  "UserId": "Your UserId",
  "Password": "Your Password",
  "TrustServerCertificate": true
}
```

Content of XmlSettings.json:
```json
{
  "Url": "http://partner.market.yandex.ru/pages/help/YML.xml"
}
```

Your project structure should look like this:
```
└── NottisimusTestProject
  └── Tests
    └── JsonOptions  
      └── XmlSettings.json  
      └── DbSettings.json  
      ...  
  └── Web  
    └── JsonOptions  
      └── XmlSettings.json  
      └── DbSettings.json  
      ...  
  └── Xml
    ...
  ```

#### 2. Connecting to MSSQL Server
You can download MSSQL Server docker image [here](https://hub.docker.com/_/microsoft-mssql-server). Follow the instuctions.


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
