using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoolEventsExam.Models.Entity
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(64, ErrorMessage = "The name cannot be longer than 64 characters!")]
        public string Name { get; set; }

        [StringLength(255, ErrorMessage = "The description cannot be longer than 255 characters!")]
        public string Description { get; set; }

        public string ImageURL { get; set; }

        public DateTime EventDate { get; set; } 

        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
