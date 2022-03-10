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

        static Queue<object> customersQueue = new Queue<object>();

        static void displayQueue()
        {
            Console.WriteLine("On Queue: ");
            foreach(object el in customersQueue)
            {
                Console.WriteLine("Ticket Number:  " + el);
            }
            Console.WriteLine();
            
        }

        static void addClientsToQueue()
        {
            Console.WriteLine();

            Client newClient = new Client();

            int ticketNum = newClient.getTicket();

            if (ticketNum <= 4)
            {
              customersQueue.Enqueue(newClient.getTicket());
              displayQueue();
             }
            else
            {
                Console.WriteLine("No more Customers Add to Queue..");
                displayQueue();
            }
        }

        static void seeNextCustomer()
        {
            Console.WriteLine();
            Console.WriteLine("Sales Assistant is ready to see the next customer, Number: "  + customersQueue.Dequeue());
        }

        static void Main(string[] args)
        {
            Console.WriteLine("######## Welcome to Ticket System App ###########");

            Timer customerToQueueTimer = new Timer();
            Timer seeCustomerTimer = new Timer();


            customerToQueueTimer.Interval = 3000;
            seeCustomerTimer.Interval = 5000;
           
            customerToQueueTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed); 
            seeCustomerTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed2);
            
            customerToQueueTimer.Start();

            seeCustomerTimer.Start();
            
            Console.Read();

            Console.Read();
            
        }

        private static void tmrTimersTimer_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
        {
            seeNextCustomer();
            displayQueue();
        }

         private static void tmrTimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            addClientsToQueue();
        }


    }
}
