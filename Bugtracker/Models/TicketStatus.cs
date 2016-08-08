using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bugtracker.Models
{
    public class TicketStatus
    {
        public TicketStatus()
        {
            this.Tickets = new HashSet<Ticket>();
        }
            public int Id { get; set; }//you're defining A, "one" singular status here...a status has an id and and name....that is what a status object has....so therefore this model should be named in the singular...does that make any more sense?Yes but I have to let it sink in and think about what you just wrote.
            public string Name { get; set; }//Ok, cool I will just leave this comnversation herre and you can look back at it and think about it....model classes were the hardest part of the class for me....they represent one thing but are used in different ways between the controllers, the database and the views....they take a little while to get your head around, i know.Yes i believe  by leaving this comment I can go back and get a better understanding of it.  I have to learn when it is singular and when we are talking about a collection of things.  (comments, statuses, tickettypes etc). Oke cool. You'll get it worked out....just takes some time. 

            public virtual ICollection<Ticket> Tickets { get; set; }
    }
}//After thinking about it.....this should be singular because all these models are representative of single entities.  For ex 1 status for 1 ticket, 1 tickettype for 1 ticket, something like that?
//I see where you are going with that line of logic but that's not really what I mean. I'm talking about just what this model represents, which is that is represents one status....disregard any thought of how this model relates to other models...just think about what kind of object you're defining here




