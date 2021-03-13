using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models.Request
{
    public class AnswerRequest
    {
        public int AnswerId { get; set; }
        public int QuestionId { get; set; }
        // Т.к нет авторизации пусть будет так
        public int UserId { get; set; }
    }
}
