using System;

namespace CollegeAdmissionApplication
{

  public enum AdmissionStatus{Default,Admitted,Canceled}
    public class AdmissionDetail
    {
        
        static int s_admissionId=1000;

        public string AdmissionID { get;  }
        public string StudentID { get; }
        public string DepartmentId{ get; }
        public DateTime AdmissionDate { get; }
        public AdmissionStatus AdmissionStatus{ get; set; }

        public AdmissionDetail(string studentID,string departmentId,DateTime admissionDate,AdmissionStatus admissionStatus)
        {
            s_admissionId++;

            AdmissionID="AID"+s_admissionId;
            StudentID=studentID;
            DepartmentId=departmentId;
            AdmissionDate=admissionDate;
            AdmissionStatus=admissionStatus;
        }
        
       




    }
}