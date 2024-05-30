using Microsoft.EntityFrameworkCore;
using QuizApp.Models;

namespace QuizApp.Context
{
    public class QuizAppDBContext : DbContext
    {
        public QuizAppDBContext(DbContextOptions<QuizAppDBContext> options) : base(options)
        {
            
        }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Round> Rounds { get; set; }
        public DbSet<Attempt> Attempts { get; set; }

    }
}
