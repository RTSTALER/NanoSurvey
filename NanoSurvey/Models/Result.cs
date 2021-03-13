using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int userId { get; set; }
        public int QuestionId { get; set; }
        public int AnswerId { get; set; }
        public Answer answer { get; set; }
        public Question question { get; set; }
    }
}
