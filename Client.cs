using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TicketingSystem
{
  class Client{

    static int ticNum = 0;
    private int ticketNum;

    public Client()
    {
      ticNum++;
      this.ticketNum = ticNum;
    }

    public void setTicket(int newNum)
    {
      ticketNum = newNum;
    }

    public int getTicket()
    {
      return ticketNum;
    }




  }

}















