namespace QuizApp.Models
{
    public class Round
    {
        public Round()
        {
            IsWon = false;
            Attempts = new List<Attempt>();
        }
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public bool IsWon { get; set; }
        public List<Attempt> Attempts { get; set; }
    }
}
