using System.ComponentModel.DataAnnotations;

namespace ProjectLIBSchoolFinal.Models
{
    public class OnlineExam
    {
        [Key]
        public int Qid { get; set; }
        public string Question { get; set; }
        public string option1 { get; set; }
        public string option2 { get; set; }
        public string option3 { get; set; }
        public string option4 { get; set; }
        public string Correct { get; set; }
        public int? TotalCorrect { get; set; }
    }
}
