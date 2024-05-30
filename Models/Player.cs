namespace QuizApp.Models
{
    public class Player
    {
        public Player()
        {
            HighScore = 0;
            Wins = 0;
            Rounds = new List<Round>();
        }
        public int Id { get; set; }
        public string PlayerName { get; set; }
        public float HighScore { get; set; }
        public int Wins { get; set; }
        public List<Round> Rounds { get; set; }
    }
}
