using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bugtracker.Models
{
    public class TicketType
    {
        public TicketType()
        {
            this.Tickets = new HashSet<Ticket>();
        }
            public int Id { get; set; }
            public string Name { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
