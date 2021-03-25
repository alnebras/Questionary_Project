using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswers;
using QuestionaryProject.Data.IRepository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QuestionaryProject.Controllers
{
    [Route("Questionary/Api/")]
    //[EnableCors("AllowOrigin")]
    public class QuestionaryController : ControllerBase
    {
        private readonly IQuestionaryRepository _questionsRepository;

        public QuestionaryController(IQuestionaryRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        [HttpGet("GetAllQuestionaries")]
        public async Task<ActionResult<QuestionsDTO>> GetAllQuestionswithAnswersAsync()
        {
            var allQuestions = await _questionsRepository.GetAllQuestionswithAnswersAsync();
            if (allQuestions == null)
                return NotFound();
            return Ok(allQuestions);
        }

        [HttpPost("AddQuestionary")]
        public async Task<ActionResult<List<UserAnswersDTO>>> AddQuestionaryAsync([FromBody] List<UserAnswersDTO> model)
        {
            var allQuestions = await _questionsRepository.AddAsync(model);
            if (allQuestions == null)
                return NotFound();
            return Ok(allQuestions);
        }

        [HttpGet("isDuplicateUserName/{userName}")]
        public bool IsDuplicateUserName(string userName)
        {
            bool result =  _questionsRepository.IsDuplicateUserName(userName);
            
            return result;
        }
    }
}
