using Microsoft.AspNetCore.Mvc;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using QuestionaryProject.Data.IRepository;
using System.Threading.Tasks;

namespace QuestionaryProject.Controllers
{
    [Route("Questionary/Api/")]
    public class QuestionaryController : ControllerBase
    {
        private readonly IQuestionaryRepository _questionsRepository;

        public QuestionaryController(IQuestionaryRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<QuestionsDTO>> GetAllQuestionaries()
        {
            var allQuestions = await _questionsRepository.GetAllQuestionsAsync();
            if (allQuestions == null)
                return NotFound();
            return Ok(allQuestions);
        }

        [HttpPost]
        public async Task<ActionResult<QuestionsDTO>> AddQuestionaryAsync([FromBody] UserAnswersSelectionDTO model)
        {
            var allQuestions = await _questionsRepository.AddAsync(model);
            if (allQuestions == null)
                return NotFound();
            return Ok(allQuestions);
        }
    }
}
