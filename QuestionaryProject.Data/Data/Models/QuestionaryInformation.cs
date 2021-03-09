using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data.Data.Models
{
    public class QuestionaryInformation
    {
        [Key]
        public int QuestionaryInformationId { get; set; }
        public string UserName { get; set; }
        public DateTime SubmissionDate { get; set; }

    }
}
