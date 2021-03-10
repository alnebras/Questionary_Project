using Microsoft.AspNetCore.Mvc;
using QuestionaryProject.Data.DTOs.Questions;
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
    }
}
