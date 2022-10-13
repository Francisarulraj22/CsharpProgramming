
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
namespace Question1;
    class program
    {
        public static void Main(string[] args)
        {
           DateTime[] dates={DateTime.Now,new DateTime(2016,8,16,9,28,0),new DateTime(2011,5,28,10,35,0),new DateTime(1976,12,25,14,30,0)};
           for(int i=0;i<dates.Length;i++)
           {
             System.Console.WriteLine("Day:"+dates[i].ToShortDateString()+" Time:"+dates[i].ToString("HH:mm:ss tt"));
            System.Console.WriteLine("Day:"+dates[i].ToShortDateString()+" Time:"+dates[i].ToLongTimeString());
           }
           }
            
    }

    
