using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tickets.Models
{
   public class TicketModel
    {
        public string FirstName { get; set; }
        public  string LastName { get; set; }
        public string TicketName { get; set; }
        public double Price { get; set; }

        public double TotalPrice = 0;
    }
}
