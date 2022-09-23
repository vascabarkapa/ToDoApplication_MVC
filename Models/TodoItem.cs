using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoApplication_MVC.Models
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public string Priority { get; set; }

        [Required]
        [DisplayName("Done")]
        public bool isDone { get; set; }
    }
}
