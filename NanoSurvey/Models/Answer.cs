﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Answer
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int QuestionId { get; set; }
        public Question question { get; set; }
    }
}
