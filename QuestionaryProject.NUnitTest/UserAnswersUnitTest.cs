using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuestionaryProject.Controllers;
using QuestionaryProject.Data;
using QuestionaryProject.Data.DTOs.UserAnswers;
using QuestionaryProject.Data.IRepository;
using QuestionaryProject.Data.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;

namespace QuestionaryProject.NUnitTest
{
    [TestClass]
    public class UserAnswersUnitTest
    {
        private readonly QuestionaryContext _context;
        private readonly IQuestionaryRepository _questionsRepository;

        public UserAnswersUnitTest(QuestionaryContext context, IQuestionaryRepository questionsRepository)
        {
            _context = context;
            _questionsRepository = questionsRepository;
        }

        [TestMethod]
        public void AddUserAnswersTest()
        {
            //// Set up Prerequisites   
            var UserAnswersRepository = new QuestionaryController(_questionsRepository);

            List<UserAnswersDTO> userAnswersListTest = new List<UserAnswersDTO>();
            {
                userAnswersListTest[0].AnswerId = 2;
                userAnswersListTest[0].QuestionId = 1;
                userAnswersListTest[0].SubmissionDate = DateTime.Now;
                userAnswersListTest[0].UserName = "Ahmed";
            };

            // Act
            IHttpActionResult actionResult = (IHttpActionResult)UserAnswersRepository.AddQuestionaryAsync(userAnswersListTest);
            var createdResult = actionResult as List<UserAnswersDTO>;

            // Assert
             Assert.IsNotNull(createdResult);
            Assert.AreEqual(userAnswersListTest, createdResult[0]);            
        }
    }
}