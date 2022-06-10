using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PracticeExercise1.Models
{
    public class Post
    {
        [Key]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public string Content { get; set; }

        public User User { get; set; }
    }
}
