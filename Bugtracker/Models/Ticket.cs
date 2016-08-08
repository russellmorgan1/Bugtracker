using System;
using System.Collections.Generic;


namespace Bugtracker.Models
{
    public class Ticket
    {
        public Ticket()
        {
            this.TicketComments = new HashSet<TicketComment>();
            this.TicketAttachments = new HashSet<TicketAttachment>();
            this.TicketHistories = new HashSet<TicketHistory>();
            this.TicketNotifications = new HashSet<TicketNotification>();
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriorityId { get; set; }
        public int TicketStatusId { get; set; }
        public string OwnerUserId { get; set; }
        public string AssignedToUserId { get; set; }
        //One thing, you want to have your classes be named in a way that they are transparently representative of the object that they are supposed to be....for example...
        public virtual ICollection<TicketComment> TicketComments { get; set; }//So now here you are saying, "This is a collection (ICollection) of comments
        public virtual ICollection<TicketHistory> TicketHistories { get; set; }//does that make sense?Yes in one instance you are talking about a single comment but in the other you have a collection of comments. Exactly
        public virtual ICollection<TicketAttachment> TicketAttachments { get; set; }
        public virtual ICollection<TicketNotification> TicketNotifications { get; set; }
        
        public virtual TicketStatus TicketStatus { get; set; }//Is TicketStatuses a lookup table>?If you mean is it one I created yes. Not exactly what I mean....a look up table is a table that you create initial values into it and then dont really change them.....it just a table that holds values and other tables can use those values and pull from that table....just like if you had a certain collection of ticket statuses that you were never going to change....like "Open", "Closed", "In Progress", "In Review", I think that it will change as we progress. because we also will have history on the tickets. so i assume that the status will change along with what is going on.....Ok, so in your history model you would have a status field showing what the status of the ticket was at the time that a history record was made....but the value for that status could still just be looked up from a table....so you would have like two fields in the status table....one for id and one for status name.....something like that....actually, lets just go look at it....that would probably make this make more sense....lol   it has an id and name field for the status.....Ok....so that is a look up table.....so it would....hmmmm.....thinking.....
        public virtual TicketPriority TicketPriority { get; set; }
        public virtual TicketType TicketType { get; set; }//I'm having a hard time thinking about how you should phrase that table....probably because I have two little children crying in my ear right now....lol.....lets just leave it the way that it is....
        public virtual Project Project { get; set; }
        //What just happend?
        public virtual ApplicationUser OwnerUser { get; set; }

        public virtual ApplicationUser AssignedToUser { get; set; }

    }
}

