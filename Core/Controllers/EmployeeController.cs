using Core.Models;
using Core.Services.Concreters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Controllers
{
    public  class EmployeeController
    {
        EmployeeService employeeService=new EmployeeService();
        public void CreatEmployee()
        {
            Console.WriteLine("Enter the name: ");
            string name=Console.ReadLine();
            Console.WriteLine("Enter the surname: ");
            string surname = Console.ReadLine();
            double salary;
            do
            {
                Console.WriteLine("Enter the salary: ");

            } while (!double.TryParse(Console.ReadLine(),out salary));
            Employee employee = new Employee()
            {
                Name=name,
                Surname=surname,
                Salary=salary
            };
            employeeService.Create(employee);
            Console.WriteLine("Employee created successfully.");

        }
        public void Delete()
        {
            int id;
            do
            {
                Console.WriteLine("Enter the delete id: ");

            } while (!int.TryParse(Console.ReadLine(), out id));
            employeeService.Delete(id);
            Console.WriteLine("Employee deleted successfully.");

        }
        public void DeleteBySalary()
        {
            double deleteSalary;
            do
            {
                Console.WriteLine("Enter the delete salary: ");

            } while (!double.TryParse(Console.ReadLine(), out deleteSalary));
            employeeService.DeleteBySalary(deleteSalary);
            Console.WriteLine("Employees with the specified salary deleted successfully.");
        }
        public void DeleteByName()
        {
            Console.WriteLine("Enter the  name of the employee(s) to delete:");
            string name = Console.ReadLine();
            employeeService.DeleteByName(name);
            Console.WriteLine("Employee is deleted for name!");
        }
        public void DeleteBySurname()
        {
            Console.WriteLine("Enter the  surname of the employee(s) to delete:");
            string surname = Console.ReadLine();
            employeeService.DeleteBySurname(surname);
            Console.WriteLine("Employee is deleted for surname!");

        }
        public void ListAllEmployees()
        {
            var employees = employeeService.GetAll();
            if (employees.Count > 0)
            {
                foreach (var employee in employees)
                {
                    Console.WriteLine(employee);
                }
            }
            else
            {
                Console.WriteLine("No employees found.");
            }
        }
      
        public void Uptade()
        {
            int id;
            do
            {
                Console.WriteLine("Enter the id of employee to update: ");

            } while (!int.TryParse(Console.ReadLine(),out id));
            Console.WriteLine("Enter the new name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the new surname:");
            string surname = Console.ReadLine();
            double salary;
            do
            {
                Console.WriteLine("Enter the new salary:");
            } while (!double.TryParse(Console.ReadLine(), out salary));
            Employee employee = new Employee()
            {
                Name = name,
                Surname = surname,
                Salary = salary
            };
            employeeService.Update(id,employee);
            Console.WriteLine("Employee updated successfully.");
        }
    }
}
