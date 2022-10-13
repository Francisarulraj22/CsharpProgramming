
using System;
namespace Events;
    class program
    {
        public static void Main(string[] args)
        {
           Event event1 = new Event("Quiz");
           Event event2 = new Event("Debugging");
           Event event3 = new Event("Presentation");
           Event event4 = new Event("Games");
        
           Event.eventlink += new EventManager(event1.ShowEvent);
           Event.eventlink += new EventManager(event2.ShowEvent);
           Event.eventlink += new EventManager(event3.ShowEvent);
           Event.eventlink += new EventManager(event4.ShowEvent);

           Event.eventlink -= new EventManager(event3.ShowEvent);
        

           Event.HandleEvent();
        }
            
    }

    
