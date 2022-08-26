using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LIBSchool_FinalProjectBackEnd.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string QuestionName { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string E { get; set; }
        public string Correct { get; set; }
        public int QuizInfoId { get; set; }
        public QuizInfo QuizInfo { get; set; }

    }
}
