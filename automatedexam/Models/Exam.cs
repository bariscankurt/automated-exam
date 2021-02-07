using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace automatedexam.Models
{
    public class Exam
    {

        [Key]
        public int Id { get; set; }
        public string examTitle { get; set; }
        public string examArticle { get; set; }
        public string question1 { get; set; }
        public string question2 { get; set; }
        public string question3 { get; set; }
        public string question4 { get; set; }
        public string question1AnswerA { get; set; }
        public string question1AnswerB { get; set; }
        public string question1AnswerC { get; set; }
        public string question1AnswerD { get; set; }
        public string question2AnswerA { get; set; }
        public string question2AnswerB { get; set; }
        public string question2AnswerC { get; set; }
        public string question2AnswerD { get; set; }
        public string question3AnswerA { get; set; }
        public string question3AnswerB { get; set; }
        public string question3AnswerC { get; set; }
        public string question3AnswerD { get; set; }
        public string question4AnswerA { get; set; }
        public string question4AnswerB { get; set; }
        public string question4AnswerC { get; set; }
        public string question4AnswerD { get; set; }
        public string question1CorrectAnswer { get; set; }
        public string question2CorrectAnswer { get; set; }
        public string question3CorrectAnswer { get; set; }
        public string question4CorrectAnswer { get; set; }
        public string time = DateTime.Now.ToShortDateString();
    }
}
