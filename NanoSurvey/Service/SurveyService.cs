using Microsoft.EntityFrameworkCore;
using NanoSurvey.Context;
using NanoSurvey.Models;
using NanoSurvey.Models.Request;
using NanoSurvey.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NanoSurvey.Service
{
    public static class SurveyService
    {

        public static QuestionResponse CreateQuestionResponse(Question question)
        {
            return new QuestionResponse(
                question.Id,
                question.Description,
                question.SurveyId,
                AnswersToAnswersResponseList(question.answers));
        }

        public static List<AnswerResponse> AnswersToAnswersResponseList(List<Answer> answers)
        {
            List<AnswerResponse> answerResponses = new List<AnswerResponse>();
            foreach (var a in answers)
                answerResponses.Add(new AnswerResponse(a.Id, a.Value, a.QuestionId));
            return answerResponses;
        }

        public static Result AnswerRequestToResult(AnswerRequest request)
        {
            Result result = new Result();
            result.AnswerId = request.AnswerId;
            result.QuestionId = request.QuestionId;
            result.userId = request.UserId;
            result.Timestamp = new DateTime().ToString("yyyyMMddHHmmssffff");
            return result;
        }

        public static async Task<NextQuestionResponse> GetNextQuestonNumber(SurveyContext _context, int QuestionId)
        {
            NextQuestionResponse response = new NextQuestionResponse();
            Question lastQuestion = await _context.Question.Where(x => x.Id == QuestionId).FirstOrDefaultAsync();
            if (lastQuestion != null)
            {
                lastQuestion = await _context.Question.Where(q => q.QuestionNumber == lastQuestion.QuestionNumber + 1).FirstOrDefaultAsync();
                if (lastQuestion != null)
                {
                    response.id = lastQuestion.QuestionNumber;
                    response.isEnd = false;
                    return response;
                }
                else
                {
                    response.id = 0;
                    response.isEnd = true;
                    return response;
                }
            }
            else
            {
                throw new Exception("Question not found");
            }

        }

        public static async Task<bool> ValidateAnswerRequest(SurveyContext _context, AnswerRequest request)
        {
            var question = await _context.Question.Where(q => q.Id == request.QuestionId).FirstOrDefaultAsync();
            var answer = await _context.Answer.Where(a => a.Id == request.AnswerId).FirstOrDefaultAsync();
            if (question == null || answer == null)
                return false;
            else
                return true;
        }
    }
}
