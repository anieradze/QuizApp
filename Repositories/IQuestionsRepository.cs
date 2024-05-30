using QuizApp.Controllers;
using QuizApp.Models;

namespace QuizApp.Repositories
{
    public interface IQuestionsRepository
    {
        public List<Question> GetQuestions();
        public Answer GetAnswer(int answerId);
        public Question AddQuestion(Question question);
        public Question DeleteQuestion(int id);
    }
}
