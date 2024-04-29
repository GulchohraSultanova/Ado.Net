using Core.DataAccessLayer;
using Core.Models;
using Core.Services.Abstracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services.Concreters
{
    class EmployeeService : IEmployeeService
    {
        EmployeeDB db;
        public EmployeeService()
        {
            this.db = new EmployeeDB();
        }
        public void Create(Employee employee)
        {
            string command = $"Insert into Employees values ('{employee.Name}','{employee.Surname}',{employee.Salary})";
            int result=db.NonQuery(command);
        }

        public void Delete(int id)
        {
            string command = $"Delete From Employees Where Id={id}";
            int result=db.NonQuery(command);
        }

        public void DeleteByName(string name)
        {
            string command = $"Delete From Employees Where Name='{name}'";
            db.NonQuery(command);
        }

        public void DeleteBySalary(double salary)
        {
            string command = $"Delete From Employees Where Salary={salary}";
            int result = db.NonQuery(command);
        }

        public void DeleteBySurname(string surname)
        {
            string command = $"Delete From Employees Where Surname='{surname}'";
            db.NonQuery(command);
        }

        public List<Employee> GetAll()
        {
            string command = "Select * from Employees";
            DataTable dataTable=db.Query(command);
            List<Employee> list = new List<Employee>();
            foreach (DataRow row in dataTable.Rows)
            {
               
                list.Add(new Employee()
                {
                    Id = int.Parse(row["Id"].ToString()),
                    Name = row["Name"].ToString(),
                    Surname = row["Surname"].ToString(),
                    Salary = double.Parse(row["Salary"].ToString())
                });

            }
            return list;
        }

  

        public void Update(int id, Employee updatedEmployee)
        {
            string command = $"Update Employees Set Name='{updatedEmployee.Name}', Surname='{updatedEmployee.Surname}', Salary={updatedEmployee.Salary} Where Id={id}";
            int result = db.NonQuery(command);
        }
    }
}
