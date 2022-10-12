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


## Exercise Two

1. Create a public Product Class - this class will contain public properties that represent each column in the Products table.
```
// For example:
public int ProductID { get; set; }
```

2. Create a IProductRepository Interface - this interface will have:
   + A GetAllProducts() method:
   ```
       IEnumerable<Product> GetAllProducts();
   ```
   + A CreateProduct(string name, double price, int categoryID) method:
   ```
   void CreateProduct(string name, double price, int categoryID);
   ```
3. Create a DapperProductRepository Class that conforms to the IProductRepository interface. Here we will define our Methods.

4.Implement our new methods in the Main method of Program.cs

## Bonus:
Create the UpdateProduct method in the DapperProductRepository class and implement in Program.cs

## Extra Bonus:
Create the DeleteProduct method
HINT: You will need to delete records from the Sales table and the Reviews table where that Product may be referenced. You can do this all in the DeleteProduct method you are creating
