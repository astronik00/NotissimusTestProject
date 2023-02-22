# NotissimusTestProject
ASP.NET MVC Application

## Technologies
- ASP.NET Core
- Entity Framework
- MSSQL Server (used Docker container from Docker Hub)
- NUnit
- Bootstrap

## How to run 
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
