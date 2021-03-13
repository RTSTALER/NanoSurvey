using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Question> questions { get; set; }
    }
}
