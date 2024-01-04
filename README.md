# About Smart Flic Enrollment API

Smart Flix is a project planned by `Campus Code` as a final curse project and here developed by `Guilherme A.V. Marques`. Smart Flix Enrollment API 
is the interface to deal with plans management and students enrollment

# Dependences

* `SQL Server 2019;`
* `Dotnet 7.0.302;`
* `.NET 7.0;`
* `SqlPackage.`


## How to run

The first thing to do is run `dotnet build Smartflix.Enrollment.API.sln` command into the solution folder to build the app. After that you need to run `dotnet run`
into the API folder to run the API.
To run the database go to SqlPackage folder or register it as enviroment variable. After that execute the command 
`SqlPackage /Action:Publish /SourceFile:"C:\workspace\Back-end-apps\Smartflix.Enrollment.API\Database\Smartflix.Enrollment.Database\bin\Debug\Smartflix.Enrollment.Database.dacpac"\`
`/TargetConnectionString:"Your connection string"`.