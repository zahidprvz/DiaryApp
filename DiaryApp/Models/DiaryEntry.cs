using System.ComponentModel.DataAnnotations;

namespace DiaryApp.Models
{
    public class DiaryEntry
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter a title!")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Title cannot be lesser than 3 or longer than 100 characters!")]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Content { get; set; } = string.Empty;
        [Required]
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
