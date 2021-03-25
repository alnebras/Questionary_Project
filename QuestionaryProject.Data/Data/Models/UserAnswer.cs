using QuestionaryProject.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuestionaryProject.Data.Data.Models
{
    public class UserAnswer
    {
        [Key]
        public int UserAnswerId { get; set; }
        public string UserName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public Answer Answer { get; set; }
    }
}
