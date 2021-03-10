using QuestionaryProject.Data.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuestionaryProject.Data.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { get; set; }
        public string AnswerName { get; set; }
        public int QuestionId { get; set; }
        public Question Questions { get; set; }
        public List<UserAnswer> UserAnswers { get; set; }
    }
}
