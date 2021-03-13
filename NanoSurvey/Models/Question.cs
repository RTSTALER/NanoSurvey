using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int SurveyId { get; set; }
        /* 
        Очень спорный момент, хотелось бы добавить условие в таблицу, 
        что бы внутри одного Survey не было одинаковых QuestionNumber,
        с другой стороны, нужно ли это пооле вообще? 
        Но и оставить порядок выдачи вопросов на СУБД то-же не правильно, 
        оставлю пока так
        */
        public int QuestionNumber { get; set; }
        public Survey survey { get; set; }
        public List<Answer> answers { get; set; }
    }
}
