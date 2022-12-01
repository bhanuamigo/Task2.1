using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PPM.Main.PPM.Model;


namespace PPM.Main.PPM.Domine
{
   public class ProjectManagement
{
    List<Project> prolifics= new List<Project>();
    
    public void addproject(Project project)
    {
        prolifics.Add(project);
    
    }

    public void viewProject()
    {
        foreach(var a in prolifics)
        {
           Console.WriteLine(a.project);
        }
    }
}
public class EmployeeData
{
    List<Employee> Employeeprolifics= new List<Employee>();
    
    public void addemployee(Employee employee)
    {
        Employeeprolifics.Add(employee);
    
    }

    public void viewEmployee()
    {
        foreach(var a in Employeeprolifics)
        {
           Console.WriteLine(a.employee);
        }
    }
}
public class EmployeeRolebase
{
    List<EmployeeRole> EmployeeRoleprolifics= new List<EmployeeRole>();
    
    public void addemployeerole(EmployeeRole employeerole)
    {
        EmployeeRoleprolifics.Add(employeerole);
    
    }

    public void viewEmployeeRole()
    {
        foreach(var a in EmployeeRoleprolifics)
        {
           Console.WriteLine(a.employeerole);
        }
    }
}
}