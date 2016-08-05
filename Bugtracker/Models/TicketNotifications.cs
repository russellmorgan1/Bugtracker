using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bugtracker.Models
{
    public class TicketNotifications
    {
        public int Id { get; set; }
        public int? TicketId { get; set; }
        public string UserId { get; set; }


        public virtual ApplicationUser User { get; set; }
        public virtual Tickets Ticket { get; set; }

    }
}