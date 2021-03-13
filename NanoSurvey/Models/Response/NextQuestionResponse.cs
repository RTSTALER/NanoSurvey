using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models.Response
{
    public class NextQuestionResponse
    {
        public int id { get; set; }
        public bool isEnd { get; set; }
    }
}
