using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models.Response
{
    public class AnswerResponse
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int QuestionId { get; set; }

        public AnswerResponse(int _Id, string _Value, int _QuestionId)
        {
            Id = _Id;
            Value = _Value;
            QuestionId = _QuestionId;
        }
    }
}
