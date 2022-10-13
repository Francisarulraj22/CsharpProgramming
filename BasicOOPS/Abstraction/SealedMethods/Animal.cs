using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SealedMethods
{
    public class Animal
    {
        public virtual void MakeSound()             //imaginary method
        {
            System.Console.WriteLine("Animal sound");
        }
    }
   
}