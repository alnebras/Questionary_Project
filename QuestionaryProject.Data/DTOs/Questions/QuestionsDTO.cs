using QuestionaryProject.Data.DTOs.Answers;
using System.Collections.Generic;

namespace QuestionaryProject.Data.DTOs.Questions
{
    public class QuestionsDTO
    {
        public string QuestionName { get; set; }
        public int QuestionId { get; set; }
        public List<AnswersDTO> Answers { get; set; }
    }
}
