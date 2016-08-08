using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bugtracker.Models
{
    public class TicketComment//This should really be called TicketComment, singular, since the object will represent one comment and not a collection of comments.....and then....
    {
        public int Id { get; set; }
        [AllowHtml]
        [Required]
        public string Comment { get; set; }
        public DateTimeOffset Created { get; set; }
        public int TicketId { get; set; }
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Ticket Ticket { get; set; }
    }
}
