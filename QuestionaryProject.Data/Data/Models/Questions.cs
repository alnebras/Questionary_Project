using System.ComponentModel.DataAnnotations;

namespace QuestionaryProject.Data.Data.Models
{
    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }
        public string QuestionName { get; set; }

    }
}
