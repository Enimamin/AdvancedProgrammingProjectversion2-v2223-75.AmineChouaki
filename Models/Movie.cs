using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Director is required.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Writer is required.")]
        public string Writer { get; set; }

        [Required(ErrorMessage = "First role is required.")]
        public string FirstRole { get; set; }

        [Required(ErrorMessage = "Second role is required.")]
        public string SecondRole { get; set; }

        [Required(ErrorMessage = "Synopsis is required.")]
        public string Synopsis { get; set; }

        [Required(ErrorMessage = "Release date is required.")]
        public DateTime ReleaseDate { get; set; }

        public string OtherNotableActors { get; set; }

        public double Rating { get; set; }

        public string Comments { get; set; }
    }
}
