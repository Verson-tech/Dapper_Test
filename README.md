# Dapper_Test
![](https://github.com/Verson-tech/Dapper_Test/blob/main/dapper-exercise-one.gif)
## Exercise One

1. Ignore appsettings.json file in .gitignore and commit
2. Create appsettings.json in netcoreapp folder
3.Run a git status to make sure appsettings is ignored
4. Add the MySql.Data Nuget Package
5. Add the Dapper Nuget package
6. Add the Microsoft.Extensions.Configuration.Json Nuget package
7. Make sure your config code is in your main method

```
var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

string connString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connString);
```

8. Create a Department class
9.Create an IDepartmentRepository interface
10. Create a DapperDepartmentRepository class
11. Create a GetAllDepartments Method
12. Create an InsertDepartment Method

_____________________________________________________________________________
