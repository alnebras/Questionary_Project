using AutoMapper;
using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.DTOs.Answers;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswers;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using QuestionaryProject.Data.Models;

namespace QuestionaryProject.AutoMapperConfigurations
{
    public class QuestionsProfile: Profile
    {
        public QuestionsProfile()
        {
            CreateMap<Question,QuestionsDTO>();
            CreateMap<Answer, AnswersDTO>();
            CreateMap<UserAnswer, UserAnswersDTO>();
            CreateMap<UserAnswersSelection, UserAnswersSelectionDTO>();
        }
    }
}
