using Core.Controllers;

namespace Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
           EmployeeController employeeController = new EmployeeController();
            employeeController.CreatEmployee();
            employeeController.Delete();
            employeeController.ListAllEmployees();
            employeeController.Uptade();
            employeeController.DeleteByName();
            employeeController.DeleteBySurname();
            employeeController.DeleteBySalary();

            
        }
    }
}
