using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models.Response
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SurveyId { get; set; }
        public List<AnswerResponse> answers { get; set; }

        public QuestionResponse(int _Id, string _Description, int _SurveyId, List<AnswerResponse> _answers)
        {
            Id = _Id;
            Description = _Description;
            SurveyId = _SurveyId;
            answers = _answers;
        }
    }
}
