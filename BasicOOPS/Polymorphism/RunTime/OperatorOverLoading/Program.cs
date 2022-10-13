using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperatorOverLoading
{
    public class Program
    {
        class Box
        {
            private double Length;
            private double Breadth;
            private double Height; 
            public Box()
            {

            }
            public Box(double length, double breadth, double height)
            {
                Length = length;
                Breadth = breadth;
                Height = height;
            }
          
            public double CalculateVolume()
            {
                return Length*Breadth*Height;
            }

     
         public static Box operator +(Box box1,Box box2)
        {
            Box box=new Box();
            box.Length=box1.Length+box2.Length;
            box.Breadth=box1.Breadth+box2.Breadth;
            box.Height=box1.Height+box2.Height;
            return box;    
        }
        }
        //overload + operator to add two objects
       
        
        public static void Main(string[] args)
        {
            Box box1=new(9.2,8.3,4.3);
            Box box2=new(3.2,4.5,6.2);
            Box box3=new(4.9,1.2,8.4);
            double volume = 0.0;
            volume = box1.CalculateVolume();
            System.Console.WriteLine("Volume of box1:"+volume);

            volume = box2.CalculateVolume();
            System.Console.WriteLine("Volume of box2:"+volume);

            volume = box3.CalculateVolume();
            System.Console.WriteLine("Volume of box3:"+volume);


            box3=box1+box2;                         //Object + Object is not possible 
            volume=box3.CalculateVolume();
           

            
        }
    }
}