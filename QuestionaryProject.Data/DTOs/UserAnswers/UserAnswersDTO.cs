using System;

namespace QuestionaryProject.Data.DTOs.UserAnswers
{
    public class UserAnswersDTO
    {
        public int UserAnswerId { get; set; }
        public string UserName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }    
    }
}
