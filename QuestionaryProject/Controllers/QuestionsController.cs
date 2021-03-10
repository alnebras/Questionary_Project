using Microsoft.AspNetCore.Mvc;
using QuestionaryProject.Data.DTOs.Questions;
using QuestionaryProject.Data.DTOs.UserAnswersSelection;
using QuestionaryProject.Data.IRepository.Questions;
using System.Threading.Tasks;

namespace QuestionaryProject.Controllers
{
    [Route("Questionary/api/GetAll")]
    public class QuestionsController : ControllerBase
    {
        private readonly IQuestionsRepository _questionsRepository;

        public QuestionsController(IQuestionsRepository questionsRepository)
        {
            _questionsRepository = questionsRepository;
        }

        [HttpGet]
        public async Task<ActionResult<QuestionsDTO>> GetAllQuestions()
        {
            var allQuestions = await _questionsRepository.GetAllQuestionsAsync();
            if (allQuestions == null)
                return NotFound();
            return Ok(allQuestions);
        }

        [HttpPost]
        public async Task<ActionResult<QuestionsDTO>> AddQuestionaryAsync([FromBody] 
                                                        UserAnswersSelectionDTO userAnswersSelectionDTO)
        {
            var allQuestions = await _questionsRepository.AddAsync(userAnswersSelectionDTO);
            if (allQuestions == null)
                return NotFound();
            return Ok(allQuestions);
        }
    }
}
