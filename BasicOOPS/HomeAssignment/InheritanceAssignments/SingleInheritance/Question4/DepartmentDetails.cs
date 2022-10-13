using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class DepartmentDetails
    {
//         Class DepartmentDetails:
// Properties: DepartmentName, Degree


    public string DepartmentName { get; set; }
    public string Degree { get; set; }

    public DepartmentDetails(string departmentname,string degree)
    {
        DepartmentName=departmentname;
        Degree=degree;   
    }
    public void ShowDetail()
    {
        System.Console.WriteLine($"Department Name:{DepartmentName}\nDegree:{Degree}");
    }

    }
}