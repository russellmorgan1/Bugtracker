﻿using Bugtracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bugtracker.Models
{
    public class TicketHistories
    {
        public int Id { get; set; }
        public int? TicketId { get; set; }
        public string Property { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public bool? Changed { get; set; }
        public string UserId { get; set; }

        public virtual Tickets Tickets { get; set; }
        public virtual ApplicationUser User { get; set; }
        
    }
}