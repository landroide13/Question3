using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TicketingSystem
{
    class Program
    {

        static Queue<string> customersQueue = new Queue<string>();

        static void AddClientsToQueue()
        {
            Timer tmrTimersTimer = new Timer();
            tmrTimersTimer.Interval = 3000; //set the interval to 3 seconds
            tmrTimersTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed); //run the code in the tmrTimersTimer_Elapsed every 3 seconds until keypress
            tmrTimersTimer.Start();
            Console.Read();

        }

        static void seeNextCustomer()
        {

            Timer tmrTimersTimer = new Timer();
            tmrTimersTimer.Interval = 5000; //set the interval to 3 seconds
            tmrTimersTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed); //run the code in the tmrTimersTimer_Elapsed every 3 seconds until keypress
            tmrTimersTimer.Start();
            Console.Read();


        }


        static void Main(string[] args)
        {
            Console.WriteLine("######## Welcome to Ticket System App ###########");



            
        }

        private static void tmrTimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Sales Assistant is ready to see the next customer.");
            
            //the rest of the code to disply the next customer in line, what number ticket is next and list all customers in a queue
        }




    }
}
