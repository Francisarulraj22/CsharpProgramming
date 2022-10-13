using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VirtualOverride
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Animal animal=new Animal();
            animal.MakeSound();
            Dog dog=new();
            dog.MakeSound();

            
        }
        
    }
}