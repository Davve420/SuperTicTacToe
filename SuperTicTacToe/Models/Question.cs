namespace SuperTicTacToe.Models
{
    public class Question
    {
        public int Id { get; set; }             // Primary key
        public string Content { get; set; }    // Question text
        public string Answer { get; set; }     // Correct answer
        public string Category { get; set; }   // E.g., "Mario Trivia"
    }
}
