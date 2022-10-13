using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstractClasses
{
    public abstract class AbstractBase
    {
      protected string name ; //normal Field
      public abstract string Name { get; set; } //abstract property
      public double Amount { get; set; } 
      public void Display() //Normal method
      {
        System.Console.WriteLine(name);
      }
      public abstract void Salary(int dates);//Abstract method
    
    }
}