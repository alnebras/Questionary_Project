using QuestionaryProject.Data.DTOs.Answers;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using QuestionaryProject.Data.Models;
using System;
using System.Collections.Generic;

namespace QuestionaryProject.Data.DTOs.UserAnswers
{
    public class UserAnswersDTO
    {
        public string UserName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int QuestionId { get; set; }

        public int AnswerId { get; set; }
        //public AnswersDTO Answer { get; set; }

        //public UserAnswersSelectionDTO UserAnswersSelection { get; set; }


    }
}
