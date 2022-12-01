using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PPM.Main.PPM.Model
{
    public class Project
{
    public string project{get;set;}

    public Project(string ProjectName)
    {
        project=ProjectName;
    }

}
public class Employee
{
    public string employee{get;set;}

    public Employee(string EmployeeName)
    {
        employee=EmployeeName;
    }
}
public class EmployeeRole
{
    public string employeerole{get;set;}

    public EmployeeRole(string EmployeeRoleName)
    {
        employeerole=EmployeeRoleName;
    }
}
}