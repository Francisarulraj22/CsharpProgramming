
using System;
using System.Collections.Generic;
namespace FilterDelegates;
class program
{
    public static void Main(string[] args)
    {
        Person person1=new Person() {Name="Arun",Age=22};
        
        Person person2=new Person() {Name="Babu",Age=18};

        Person person3=new Person() {Name="Arun",Age=35};

        Person person4=new Person() {Name="Anitha",Age=42};

        Person person5=new Person() {Name="Arty",Age=2};

        Person person6=new Person() {Name="Alexander",Age=50};

        Person person7=new Person() {Name="Rani",Age=45};

        List<Person>people=new List<Person>(){person1,person2,person3,person4,person5,person6};


        DisplayPeople("Children",people,Ischild);
        DisplayPeople("Voters",people,IsVoter);
        DisplayPeople("Adult",people,IsAdult);
        DisplayPeople("Senior Citizen",people,IsSenior);

        

        static void DisplayPeople(string title,List<Person> people,FilterDelegate filter)
        {
            System.Console.WriteLine($"\n------------------------>>>>>>>>>  People in {title} list are:  <<<<<<<<<<------------------------\n");
           
            foreach (Person p in people)
            {
                if(filter (p))
                {
                    System.Console.WriteLine($"\t{p.Name}, is {p.Age} years Old");
                }
            }
        }
        static bool Ischild(Person p)
        {
            return p.Age < 15;
        }
        static bool IsVoter(Person p)
        {
            return p.Age >= 18;
        }
        static bool IsAdult(Person p)
        {
            if(p.Age>=18 && p.Age<=50)
            {
                return true;
            }
            else
            return false;
        }
         static bool IsSenior(Person p)
        {
            return p.Age>50;
            
        }
        }
       

}
     
  
    

    
