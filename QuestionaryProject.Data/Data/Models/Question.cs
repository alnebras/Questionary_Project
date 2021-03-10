using QuestionaryProject.Data.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuestionaryProject.Data.Data.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
