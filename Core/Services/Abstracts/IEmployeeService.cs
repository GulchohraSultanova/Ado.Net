using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Abstracts
{
    public  interface IEmployeeService
    {
        void Create(Employee employee);
        List<Employee> GetAll();
        void Delete(int id);
        void DeleteBySalary(double salary);
        void Update(int id,Employee updatedEmployee);
        void DeleteByName(string name);
        void DeleteBySurname(string surname);
      
     

    }
}
