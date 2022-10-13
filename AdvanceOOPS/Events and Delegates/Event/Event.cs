using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events
{
    public delegate void EventManager();
    public class Event
    {
        private string _eventname;

        public static event EventManager eventlink=null;  //event keyword and evenlink-object / eventmanager is a handler

        static int i;

        public Event(string eventName)
        {
            _eventname=eventName;
        }
        public static void HandleEvent()
        {
            i=0;
            System.Console.WriteLine("......................<<< User Registeration >>>........................");
            System.Console.WriteLine("\n<<<<<<<<<<<<<<-------------------- Staring the Following events --------------->>>>>>>>>>>>>\n");
            eventlink();       //Event trigering
        }
        public void ShowEvent()
        {
            ++i;
            System.Console.WriteLine($"\tEvent No : {i} is : {_eventname}");
        }




        
    }
}