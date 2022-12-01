using System;
using PPM.Main.PPM.Model;
using PPM.Main.PPM.Domine;
namespace PPM.Main.PPM.UI
{
    public class UI
    {
        public void view(){
        Console.WriteLine("");
        Console.WriteLine("WELCOME TO PROLIFICS PROJECT MANAGEMENT ");
        Console.WriteLine("SELECT OPERATIONS");
        Console.WriteLine("");
        Console.Write("Enter 1 for add  project               ");
        Console.WriteLine("         Enter 2 for view all projects");
        Console.WriteLine("");
        Console.Write("Enter 3 for add Employee              ");
        Console.WriteLine("         Enter 4 for view all Employees");
        Console.WriteLine("");
        Console.Write("Enter 5 for add  EmployeeRole                  ");
        Console.WriteLine("Enter 6 for view all EmployeeRoles");
        Console.WriteLine("");
        Console.WriteLine("Enter x  for exit");
        ProjectManagement obj = new ProjectManagement();
        EmployeeData obj1 = new EmployeeData();
        EmployeeRolebase obj2 = new EmployeeRolebase();

        var userInput = Console.ReadLine();

        while (true)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Project Name:");
                    var Project = Console.ReadLine();
                    var projectadd=new Project(Project);
                    obj.addproject(projectadd);
                    Console.WriteLine("Project added successfully");
                    break;
                case "2":
                    obj.viewProject();
                    break;
                case "3":
                    Console.WriteLine("Employee Name:");
                    var Employee = Console.ReadLine();
                    var employeeadd=new Employee(Employee);
                    obj1.addemployee(employeeadd);
                    Console.WriteLine("Employee added successfully");
                    break;
                case"4":
                    obj1.viewEmployee();
                    break;
                case "5":
                    Console.WriteLine("Employee Role");
                    var EmployeeRole = Console.ReadLine();
                    var employeeroleadd = new EmployeeRole(EmployeeRole);
                    obj2.addemployeerole(employeeroleadd);
                    Console.WriteLine("EmployeeRole added successfully");
                    break;
                case "6":
                    obj2.viewEmployeeRole();
                    break;
                case "x":
                     return;
                default:
                    Console.WriteLine("SELECT VAILD OPERATION");
                    break;
            }
            Console.WriteLine("Select operation");
            userInput = Console.ReadLine();
    
        }

    }
    }
}  
    