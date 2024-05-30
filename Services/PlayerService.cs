using QuizApp.Models;
using QuizApp.Repositories;

namespace QuizApp.Services
{
    public class PlayerService
    {
        //private readonly IPlayerRepository _playerRepository;
        //private readonly IQuestionsRepository _questionsRepository;
        //public PlayerService(IPlayerRepository playerRepository)
        //{
        //    _playerRepository = playerRepository;
        //}

        //public Player CreatePlayer(string name)
        //{
        //    var newPlayer = new Player(name);
        //    var round = new Round();
        //    newPlayer.Rounds.Add(round);
        //    var player = _playerRepository.AddPlayer(newPlayer);
        //    return player;
        //}
        //public Round UpdateRound(int roundId, int answerId)
        //{
        //    var round = _playerRepository.GetRound(roundId);
        //    var answer = _questionsRepository.GetAnswer(answerId);

        //    var input = new Input();
        //    input.IsCorrect = answer.IsCorrect;
        //    input.AnswerID = answerId;

        //    round.Inputs.Add(input);
        //    return round;
        //}
    }
}
