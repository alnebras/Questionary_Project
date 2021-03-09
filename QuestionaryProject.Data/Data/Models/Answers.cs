using System;
using System.ComponentModel.DataAnnotations;

namespace QuestionaryProject.Data.Data.Models
{
    public class Answers
    {
        [Key]
        public int AnswerId { get; set; }
        public string AnswerName { get; set; }

    }
}
