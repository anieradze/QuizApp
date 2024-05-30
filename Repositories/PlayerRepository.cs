using QuizApp.Context;
using QuizApp.Models;
using System.Numerics;

namespace QuizApp.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly QuizAppDBContext _context;
        public PlayerRepository(QuizAppDBContext context)
        {
            _context = context;
        }
        public List<Player> GetAllPlayers() 
        { 
            return _context.Players.ToList();
        }
        public Player AddPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
            return player;
        }

        public Player DetelePlayer(int id)
        {
            var player = _context.Players.FirstOrDefault(x => x.Id == id);
            _context.Players.Remove(player);
            _context.SaveChanges();
            return player;
        }
    }
}
