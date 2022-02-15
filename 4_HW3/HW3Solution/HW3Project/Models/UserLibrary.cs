using System.ComponentModel.DataAnnotations;

namespace HW3Project.Models
{
    public class UserLibrary
    {
        [Required(ErrorMessage = "Please enter a movie id")]
        public int movieId { get; set; }
        public string movieTitle { get; set; }
        public string dueDate { get; set; }
    }
}