using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayClass
{
    class Ticket
    {
        private int id;

        public int TicketID
        {
            get { return id; }
            set { id = value; }
        }

        private string route;

        public string Route
        {
            get { return route; }
            set { route = value; }
        }


    }
}
