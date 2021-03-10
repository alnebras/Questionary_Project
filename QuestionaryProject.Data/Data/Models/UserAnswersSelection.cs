using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuestionaryProject.Data.Models
{
    public class UserAnswersSelection
    {
    
        public string UserName { get; set; }
        public DateTime SubmissionDate { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public List<UserAnswer> UserAnswers { get; set; }

    }
}
