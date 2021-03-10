using QuestionaryProject.Data.DTOs.UserAnswers;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using System;
using System.Collections.Generic;

namespace QuestionaryProject.Data.DTOs.UserAnswersSelection
{
    public class UserAnswersSelectionDTO
    {
        public string UserName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int QuestionId { get; set; }
        public List<UserAnswersDTO> UserAnswers { get; set; }

    }
}
