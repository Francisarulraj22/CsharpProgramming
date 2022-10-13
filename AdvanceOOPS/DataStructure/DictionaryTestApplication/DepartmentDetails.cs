using System;

namespace CollegeAdmissionApplication
{
  
   
    
    public class DepartmentDetails 
    {
       
        private static int s_departmentId=100;

        public string DepartmentId{get;set;}

        public string Departments { get;set; }
        public int NumberOfSeats { get; set; }
        public DepartmentDetails(string departmentId,String departmentname,int numberofseats)
    {
        s_departmentId++;
        DepartmentId="DID"+s_departmentId;
        Departments=departmentname;
        NumberOfSeats=numberofseats;
        
    }
    
    


    }

   
    // public bool (double cutOff)
    //         {
    //             double average=(double)(Physics+Chemistry+Mathematics/3.0);
    //             if(average>=cutOff)
    //             return(true);
    //             else
    //             return(false);
                
    //         }
}