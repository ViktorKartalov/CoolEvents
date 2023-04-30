using Microsoft.AspNetCore.Identity;

namespace CoolEventsExam.Models.Entity
{
    public class User : IdentityUser
    {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
