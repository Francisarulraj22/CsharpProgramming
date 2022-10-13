using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

///<summary>
/// Used to process the College admission using this application
///</summary>
 
namespace CollegeAdmission

{
      /// <summary>
    /// Class <cref="StudentDetails"  Used to Select Gender Of student
    /// </summary>
    public enum Gender { Default,Male,Female,Transgender};
  
        
    public class StudentDetails
    {
  

    //    private string _name="Arun";//field_declaration
        //public string Name { get(return _name); set(_name=value); }//property
   
        /// <summary>
        /// statisc field used to auto increment register number
        ///  <see cref="StudentDetails"/>Class
        /// 
        /// <summary>
        private static int s_registernumber=3000;
        
        public string RegisterNumber { get;  }
        
             //it can be Access from any object
        /// <summary>
        /// This is property of Name
        /// </summary>
    
         
        public string Name { get; set; }//Auto property

        /// <summary>
        /// This is propery of Fathername
        /// </summary>
      
        public string FatherName { get; set; }
        /// <summary>
        /// This is propery of DateofBirth
        /// </summary>
        public DateTime DateofBirth { get; set; }
        /// <summary>
        /// This is propery of Gender
        /// </summary>
        public Gender Gender { get; set; }
        /// <summary>
        /// This is propery of PhoneNumber
        /// </summary>
        public long Phonenumber { get; set; }
        /// <summary>
        /// This is propery of MailId
        /// </summary>
        public string MailId { get; set; }
        /// <summary>
        /// This is propery of Physics
        /// </summary>
        public int Physics { get; set; }
        /// <summary>
        /// This is propery of Mathematics
        /// </summary>
        public int  Mathematics { get; set; }
        /// <summary>
        /// This is propery of Chemistry
        /// </summary>
        public int  Chemistry { get; set; }

        ///<summary>
        /// Constucrtor of<cref="StudentDetails"/> class used to intialize values to its properties">
        /// </summary>
        /// <param name="name"> Parameter used to intialize name to its property</param>
        /// <param name="fathername"> Parameter used to intialize FatherName to its property</param>
        /// <param name="dateOfbirth"> Parameter used to intialize Dateofbirth to its property</param>
        /// <param name="gender"> Parameter used to intialize Gender to its property</param>
        /// <param name="phoneNumber"> Parameter used to intialize PhoneNumber to its property</param>
        /// <param name="mailId"> Parameter used to intialize MailId to its property</param>
        /// <param name="physics"> Parameter used to intialize Physics Mark to its property</param>
        /// <param name="chemistry"> Parameter used to intialize Chemistry to its property</param>
        /// <param name="maths"> Parameter used to intialize Maths to its property</param>
         
        public StudentDetails(string name,string fatherName ,DateTime datofBirth,Gender gender,long PhoneNumber,string mailId,int physics,int chemistry,int maths )
        {
            //parameterize constructor
            s_registernumber++;
            RegisterNumber="SF"+s_registernumber;
            Name=name;
            FatherName=fatherName;
            DateofBirth=datofBirth;
            Gender=gender;
            Phonenumber=PhoneNumber;
            MailId=mailId;
            Chemistry=chemistry;
            Mathematics=maths;

        }
        /// <summary>
        /// Method is Check Eligibility get cutOff and Evaluate and gives result
        /// </summary>
        /// <param name="cutOff"> It show the cut Off value for eligibility</param>
        /// <returns>Returns true If eligible Else false</returns>
    public bool CheckEligibility(double cutOff)
    {
        double average=(double)(Physics+Chemistry+Mathematics/3.0);
        if(average>=cutOff)
        return(true);
        else
        return(false);
        
    }

    public void ShowDetails()
            {
                System.Console.WriteLine("Register Number is:"+RegisterNumber);
                System.Console.WriteLine($"Register number:{RegisterNumber}\nName is:{Name}\nFather's Name is:{FatherName}\nDOB:{DateofBirth}\nGender:{Gender}\nPhoneNumber:{Phonenumber}\nMail ID:{MailId}\nPhysics Marks:{Physics}\nChemistry Marks:{Chemistry}\nMaths Marks:{Mathematics}"); 
            
            }
    }
}