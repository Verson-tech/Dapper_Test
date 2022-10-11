using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Test
{
    internal class DepartmentRepo
    {
        private readonly IDbConnection _connection;

        public DepartmentRepo(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM departments;");
        }
        public void CreateDepartment(string departmentName)
        {
            _connection.Execute("Insert into departments (Name) VALUES (@name);",
              new { name = departmentName });
        }
        public void UpdateDepartment(int departmentID, string updateDepartmentName)
        {
            _connection.Execute("UPDATE departments SET Name = @name WHERE DepartmentID = @id;",
                new { name = updateDepartmentName, id = departmentID});
        }
        public void DeleteDepartment(int id)
        {
            _connection.Execute("DELETE FROM departments WHERE DepartmentID = @departmentID;",
                new { departmentID = id });
        }
    }
}
