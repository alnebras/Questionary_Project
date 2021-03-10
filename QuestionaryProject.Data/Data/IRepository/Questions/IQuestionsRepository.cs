using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data.IRepository.Questions
{
    public interface IQuestionsRepository
    {
        Task<List<QuestionsDTO>> GetAllQuestionsAsync();
        Task<UserAnswersSelectionDTO> AddAsync(UserAnswersSelectionDTO model);

    }
}
