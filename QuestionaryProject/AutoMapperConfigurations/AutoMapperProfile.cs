using AutoMapper;
using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.DTOs.Answers;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswers;
using QuestionaryProject.Data.Models;

namespace QuestionaryProject.AutoMapperConfigurations
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Question,QuestionsDTO>();
            CreateMap<QuestionsDTO, Question>();
            CreateMap<Answer, AnswersDTO>();
            CreateMap<AnswersDTO, Answer>();
            CreateMap<UserAnswer, UserAnswersDTO>();
            CreateMap<UserAnswersDTO, UserAnswer>();
         
        }
    }
}
