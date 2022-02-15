using System;
using System.ComponentModel.DataAnnotations;

namespace HW3Project.Models
{
    public class UserLibrary
    {
        [Required(ErrorMessage = "Please enter a movie id")]
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string DueDate
        {
            get { return DueDate; }
            set 
            { 
                DateTime today = DateTime.Now;
                DueDate = today.AddDays(14).ToString(); 
            }
        }
    }
}