using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NanoSurvey.Context;
using NanoSurvey.Models;
using NanoSurvey.Models.Request;
using NanoSurvey.Models.Response;
using NanoSurvey.Service;

namespace NanoSurvey.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyController : ControllerBase
    {
        private readonly SurveyContext _context;

        public SurveyController(SurveyContext context)
        {
            _context = context;
        }


        // GET: api/Survey/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionResponse>> GetQuestion(int id)
        {
            var question = await _context.Question.Where(x => x.Id == id).Include(b => b.answers).FirstOrDefaultAsync();

            if (question == null)
            {
                return NotFound();
            }

            return SurveyService.CreateQuestionResponse(question);
        }

        // POST: api/Surveys
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<NextQuestionResponse>> SetAnswer(AnswerRequest answer)
        {
            if (!await SurveyService.ValidateAnswerRequest(_context, answer))
                return NotFound();
            _context.Result.Add(SurveyService.AnswerRequestToResult(answer));
            await _context.SaveChangesAsync();
            return await SurveyService.GetNextQuestonNumber(_context, answer.QuestionId);
        }
    }
}
