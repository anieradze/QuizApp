using QuizApp.Models;

namespace QuizApp.Repositories
{
    public interface IPlayerRepository
    {
        List<Player> GetAllPlayers();
        Player AddPlayer(Player player);
        Player DetelePlayer(int id);
    }
}
