using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApplication_MVC.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DisplayName("Date and Time")]
        public DateTime DateAndTime { get; set; }

        [Required]
        public string Priority { get; set; }

        [Required]
        [DisplayName("Done")]
        public bool isDone { get; set; }
    }
}
