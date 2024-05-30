using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuizApp.Context;
using QuizApp.Models;

namespace QuizApp.Repositories
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly QuizAppDBContext _context;
        public QuestionsRepository(QuizAppDBContext context)
        {
            _context = context;
        }
        public List<Question> GetQuestions()
        {
            return _context.Questions.Include("Answers").ToList();
        }

        public Question AddQuestion(Question question)
        {
            _context.Questions.Add(question);
            _context.SaveChanges();
            return question;
        }

        public Question DeleteQuestion(int id)
        {
            var question = _context.Questions.FirstOrDefault(x => x.ID == id);
            _context.Questions.Remove(question);
            _context.SaveChanges();
            return question;
        }
        public Answer GetAnswer(int id)
        {
            var answer = _context.Answers.FirstOrDefault(x => x.ID == id);
            return answer;
        }
    }
}