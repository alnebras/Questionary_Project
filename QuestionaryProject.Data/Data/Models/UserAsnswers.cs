using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QuestionaryProject.Data.Data.Models
{
    public class UserAsnswers
    {
        [Key]
        public int UserAsnswersId { get; set; }

        public int QuestionaryInformationId { get; set; }
        public QuestionaryInformation QuestionaryInformation { get; set; }

        public int QuestionId { get; set; }
        public Questions Question { get; set; }

        public List<Answers> Answers { get; set; }

    }
}
