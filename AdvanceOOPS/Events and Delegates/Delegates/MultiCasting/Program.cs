
using System;
namespace Delegate;
    public delegate int Calculator(int n);
    class program
    {
        static int value = 10;

        public static int AddNum(int number)
        {
            value+=number;
            return value;
        }
        public static int MulNum(int number)
        {
            value*=number;
            return value;
        }
        public static int GetNum()
        {
            return value;
        }
        public static void Main(string[] args)
        {
           Calculator calc ;
           Calculator calc1 = new Calculator(AddNum); 
           Calculator calc2 = new Calculator(MulNum);
           calc=calc1;
           calc+=calc2;
           calc(10);
           System.Console.WriteLine("Vslue of "+GetNum());

           
        }
            
    }

    
