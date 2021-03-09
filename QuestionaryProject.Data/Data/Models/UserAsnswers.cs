using System.Collections.Generic;
namespace QuestionaryProject.Data.Data.Models
{
    public class UserAsnswers
    {
        public int QuestionaryInformationId { get; set; }
        public QuestionaryInformation QuestionaryInformation { get; set; }
        public int QuestionId { get; set; }
        public Questions Question { get; set; }
        public List<Answers> Answers { get; set; }

    }
}
