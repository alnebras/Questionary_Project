using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using QuestionaryProject.Data.Data.Models;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswers;
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
        /// <summary>
        /// Save new questionary 
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public async Task<List<UserAnswersDTO>> AddAsync(List<UserAnswersDTO> model)
        {
            int storedQuestionscount = _context.Questions.Count();

            if (model.Count < storedQuestionscount)
                throw new Exception("Please select all questions with answers");
            else if (IsDuplicateUserName(model[0].UserName) == true)
                throw new Exception("User already exists!");
            else
            {
                var userAnswers = _mapper.Map<List<UserAnswer>>(model);
                var dateNow = DateTime.Now;
                foreach (var item in userAnswers)
                {
                    item.SubmissionDate = dateNow;
                }
                await _context.UserAsnswers.AddRangeAsync(userAnswers).ConfigureAwait(false);

                await _context.SaveChangesAsync().ConfigureAwait(false);
                var userAnswerDTO = _mapper.Map<List<UserAnswersDTO>>(userAnswers);

                return userAnswerDTO;
            }
        }
        /// <summary>
        /// get all
        /// </summary>
        /// <returns></returns>
        public async Task<List<QuestionsDTO>> GetAllQuestionswithAnswersAsync()
        {
            var questions = await _context.Questions.Include(x => x.Answers)
                               .ToListAsync()
                               .ConfigureAwait(false);
            var questionsDto = _mapper.Map<List<QuestionsDTO>>(questions);

            return questionsDto;
        }

        /// <summary>
        /// check if UserName is avilable
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public bool IsDuplicateUserName(string userName)
        {
            var result = _context.UserAsnswers
                                .Any(name => name.UserName == userName);
            if (result == true)
                return true;
            else
                return false;
        }
    }
}
