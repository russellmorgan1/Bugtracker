using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bugtracker.Models
{
    public class Project//So, now that we have changed all of these models we need to update your database. All of the tables....the ones related to the models we just changed will be changed....it's not going to like it but we should be able to force the mirgation to the database and everything should be fine
    {
        public Project()
        { 
            Users = new HashSet<ApplicationUser>();
            Tickets = new HashSet<Ticket>();
}

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}



