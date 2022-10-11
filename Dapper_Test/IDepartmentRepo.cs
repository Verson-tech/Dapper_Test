using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_Test
{
    public interface IDepartmentRepo
    {
        public void CreateDepartment(string departmentName);
        public void DeleteDepartment(string departmentName);
        public IEnumerable<Department> GetAllDepartments();
        public void UpdateDepartment(int id,string updateDepartmentName);
    }
}
