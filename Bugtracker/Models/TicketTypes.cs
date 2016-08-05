using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bugtracker.Models
{
    public class TicketTypes
    {
        public TicketTypes()
        {
            Tickets = new HashSet<Tickets>();
        }
            public int Id { get; set; }
            public string Name { get; set; }

        public virtual ICollection<Tickets> Tickets { get; set; }
    }
}
