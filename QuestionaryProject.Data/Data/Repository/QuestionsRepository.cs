using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.IRepository.Questions;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;

namespace QuestionaryProject.Data.Data.Repository
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly QuestionaryContext _context;
        private readonly IMapper _mapper;

        public QuestionsRepository(QuestionaryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Task<List<UserAnswersSelectionDTO>> AddAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<QuestionsDTO>> GetAllQuestionsAsync()
        {
            var questions = await _context.Questions.Include(x =>x.Answers)
               .ToListAsync()
               .ConfigureAwait(false);
            var questionsDto = _mapper.Map<List<QuestionsDTO>>(questions);

            return questionsDto;

        }
    }
}
