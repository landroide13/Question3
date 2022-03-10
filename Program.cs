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
        static int count = 0;
        static void displayQueue()
        {
            if(customersQueue.Count == 0)
            {
             Console.WriteLine("No Customers on Queue");
            }
            else
            {
                Console.WriteLine("On Queue: ");
                foreach(object el in customersQueue)
                {
                    Console.WriteLine("Ticket Number:  " + el);
                }
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
                count++;
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

                customerToQueueTimer.Elapsed += new ElapsedEventHandler(Timer);
                seeCustomerTimer.Elapsed += new ElapsedEventHandler(Timer2);

                customerToQueueTimer.Start();
                seeCustomerTimer.Start();

                Console.Read();

                if(count >= 4)
                {
                    Console.WriteLine("Timer Stop..");
                    customerToQueueTimer.Stop();
                    seeCustomerTimer.Stop();

                    customerToQueueTimer.Dispose();
                    seeCustomerTimer.Dispose();
                }

        }

         static void Timer2(object sender, System.Timers.ElapsedEventArgs e)
        {
            seeNextCustomer();
            displayQueue();
        }

         static void Timer(object sender, System.Timers.ElapsedEventArgs e)
        {
            addClientsToQueue();
        }


    }
}
