using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data.IRepository
{
    public interface IQuestionaryRepository
    {
        Task<List<QuestionsDTO>> GetAllQuestionswithAnswersAsync();
         Task<List<UserAnswersDTO>> AddAsync(List<UserAnswersDTO> model);
        bool IsDuplicateUserName(string userName);

    }
}
