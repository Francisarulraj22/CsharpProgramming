using System;
namespace Question9;
class program
{
    int days=0;
    public static void Main(string[] args)
    {
        int days=0;
        int salary,salarydate;
        System.Console.WriteLine("Enter the month:");
        string month=Console.ReadLine().ToLower();
        System.Console.WriteLine("Enter Leave taken in month:");
        int leave=int.Parse(Console.ReadLine());
        switch (month)
        {
            case "january":
            {
                days=31;
                break;
            }
            case "febraury":
            {
                days=28;
                break;
            }
            case "march":
            {
                days=31;
                break;
            }
            case "april":
            {
                days=30;
                break;
            }
            case "may":
            {
                days=31;
                break;
            }
             case "june":
            {
                days=30;
                break;
            }
            case "july":
            {
                days=31;
                break;
            }
            case "august":
            {
                days=31;
                break;
            }
            case "september":
            {
                days=30;
                break;
            }
            case "October":
            {
                days=31;
                break;
            }
            case "november":
            {
                days=30;
                break;
            }
            case "december":
            {
                days=31;
                break;
            }
            default:
                break;
         }
         salarydate=days-leave;
         salary=salarydate*500;
         System.Console.WriteLine($"Salary:Rs.{salary} ");       

    }
}