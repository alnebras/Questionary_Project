using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using QuestionaryProject.Data.IRepository;
using QuestionaryProject.Data.Models;

namespace QuestionaryProject.Data.Repository
{
    public class QuestionaryRepository : IQuestionaryRepository
    {
        private readonly QuestionaryContext _context;
        private readonly IMapper _mapper;

        public QuestionaryRepository(QuestionaryContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<UserAnswersSelectionDTO> AddAsync(UserAnswersSelectionDTO model)
        {
            var userAnswerSelection = _mapper.Map<UserAnswersSelection>(model);

            await _context.UserAnswersSelection.AddAsync(userAnswerSelection).ConfigureAwait(false);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            var userAnswerSelectionDTO = _mapper.Map<UserAnswersSelectionDTO>(userAnswerSelection);

            return userAnswerSelectionDTO;
        }

        public async Task<List<QuestionsDTO>> GetAllQuestionsAsync()
        {
            var questions = await _context.Questions.Include(x => x.Answers)
                               .ToListAsync()
                               .ConfigureAwait(false);
            var questionsDto = _mapper.Map<List<QuestionsDTO>>(questions);

            return questionsDto;

        }
    }
}
