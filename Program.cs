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
            Console.WriteLine("On the Queue: " + customersQueue.Count);

            foreach(object el in customersQueue)
            {
                Console.Write(" " + el);
            }

            Console.WriteLine();
        }

        static void addClientsToQueue()
        {
            Client newClient = new Client();
            customersQueue.Enqueue(newClient.getTicket());
        }

        static void seeNextCustomer()
        {
            Console.WriteLine();
            displayQueue();
            customersQueue.Dequeue();
        }

        // static void SetTimer(int time)
        // {

        //     Timer seeCustomerTimer = new Timer();
        //     seeCustomerTimer.Interval = time; //set the interval to 3 seconds
        //     seeCustomerTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed); //run the code in the tmrTimersTimer_Elapsed every 3 seconds until keypress
        //     seeCustomerTimer.Start();
        //     Console.Read();

        // }


        static void Main(string[] args)
        {
            Console.WriteLine("######## Welcome to Ticket System App ###########");

            Timer customerToQueueTimer = new Timer();
            Timer seeCustomerTimer = new Timer();


            customerToQueueTimer.Interval = 3000;
            seeCustomerTimer.Interval = 5000;
           

            seeCustomerTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed2);
            customerToQueueTimer.Elapsed += new ElapsedEventHandler(tmrTimersTimer_Elapsed); 
            
            seeCustomerTimer.Start();
            customerToQueueTimer.Start();

            Console.Read();

            Console.Read();
            
            
        }

        private static void tmrTimersTimer_Elapsed2(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Sales Assistant is ready to see the next customer.");

            seeNextCustomer();
        }

         private static void tmrTimersTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("New customer Arrived");

            addClientsToQueue();

            displayQueue();
          
        }




    }
}
