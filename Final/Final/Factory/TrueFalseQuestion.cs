namespace Final.Factory
{
    /// <summary>
    /// Represents a True/False question implementing the IQuestion interface.
    /// </summary>
    public class TrueFalseQuestion : IQuestion
    {
        /// <summary>
        /// Gets or sets the question text.
        /// </summary>
        public string Question { get; set; }

        /// <summary>
        /// Gets or sets the correct answer (true or false).
        /// </summary>
        public bool CorrectAnswer { get; set; }

        /// <summary>
        /// Returns the question text formatted for display, indicating it is a True/False question.
        /// </summary>
        /// <returns>Formatted question string.</returns>
        public string GetQuestionText()
        {
            return $"{Question} (True/False)";
        }

        /// <summary>
        /// Checks if the provided answer matches the correct answer.
        /// </summary>
        /// <param name="answer">The user's answer as a string ("true" or "false").</param>
        /// <returns>True if the answer is correct; otherwise, false.</returns>
        public bool CheckAnswer(string answer)
        {
            return bool.TryParse(answer, out bool result) && result == CorrectAnswer;
        }
    }
}
