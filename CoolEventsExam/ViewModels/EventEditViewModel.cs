using System.ComponentModel.DataAnnotations;

namespace CoolEventsExam.ViewModels
{
    public class EventEditViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64, ErrorMessage = "The name cannot be longer than 64 characters!")]
        public string Name { get; set; }

        [Required]
        [StringLength(255, ErrorMessage = "The description cannot be longer than 255 characters!")]
        public string Description { get; set; }

        [Required]
        public string ImageURL { get; set; }

        [Required]
        public DateTime EventDate { get; set; }
    }
}
