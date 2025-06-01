namespace Final.Factory
{
    // Represents a multiple-choice question implementing the IQuestion interface
    public class MCQQuestion : IQuestion
    {
        // The text of the question
        public string Question { get; set; }

        // The available answer options
        public string[] Options { get; set; }

        // The correct answer option
        public string CorrectOption { get; set; }

        // Returns the question text along with its options as a formatted string
        public string GetQuestionText()
        {
            return $"{Question}\nOptions: {string.Join(", ", Options)}";
        }

        // Checks if the provided answer matches the correct option (case-insensitive)
        public bool CheckAnswer(string answer)
        {
            return answer.Equals(CorrectOption, StringComparison.OrdinalIgnoreCase);
        }
    }
}
