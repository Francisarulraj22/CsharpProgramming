
namespace CollegeAdmissionApplication;
    static class program
    {
        public static void Main(string[] args)
        {
           Files.Create();
           Operations.DefaultDepartmentDetails();
           Operations.DefaultAdmissionDetails(); 
           Operations.SetSampleData();
           Files.ReadFile();
          
           Operations.Mainmenu();
           Files.WriteToFiles();
           
                
        }
    }

    
