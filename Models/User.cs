using System.ComponentModel.DataAnnotations;

namespace PracticeExercise1.Models
{
    public class User
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public ICollection<Comment> Comments { get; set; }
    }
}
