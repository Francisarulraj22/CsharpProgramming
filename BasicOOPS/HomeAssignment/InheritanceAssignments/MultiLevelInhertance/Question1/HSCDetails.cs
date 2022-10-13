using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class HSCDetails:StudentDetails
    {
        public int Physics { get; set; }// property declaration only
        public int Maths { get; set; }
        public int Chemistry { get; set; }
        public int Total { get; set; }
        public double Average { get; set; }
        public long HSCMarksheet { get; set; }

        public HSCDetails(string name,string fatherName,Gender gender,long phonenumber,Department department,string academicyear):base(name,fatherName,  gender,  phonenumber,department,academicyear)
        {
            HSCMarksheet=16846;
            
        }
         public void GetMark(int physics,int maths,int chemistry)
        {
            Physics=physics;
            Maths=maths;
            Chemistry=chemistry;

        }
        public void Calculate()
        {  
            Total=Maths+Chemistry+Physics;
            System.Console.WriteLine("Total:"+Total);
            Average=(double)Total/3.0;
            System.Console.WriteLine("Average:"+Average);
          
        }
        public void ShowMarksheet()
        {
            
            System.Console.WriteLine("HSCMarksheet:"+HSCMarksheet);
            System.Console.WriteLine("Physics:"+Physics);
            System.Console.WriteLine("Maths:"+Maths);
            System.Console.WriteLine("Chemistry:"+Chemistry);

        }
    }
}