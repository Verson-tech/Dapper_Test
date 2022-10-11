

using Dapper_Test;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

var config = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

var connectionString = config.GetConnectionString("DefaultConnection");

IDbConnection conn = new MySqlConnection(connectionString);

var departmentRepo = new DepartmentRepo(conn);


var departments = departmentRepo.GetAllDepartments();

foreach (var department in departments)
{
    Console.WriteLine(department.DepartmentID);
    Console.WriteLine(department.Name);
    Console.WriteLine();
}