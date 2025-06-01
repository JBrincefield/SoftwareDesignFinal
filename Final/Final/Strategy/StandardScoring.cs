namespace Final.Strategy
{
    /// <summary>
    /// Implements the standard scoring strategy for quizzes.
    /// Calculates the score as a percentage of correct answers.
    /// </summary>
    public class StandardScoring : IScoringStrategy
    {
        /// <summary>
        /// Calculates the score based on the number of correct answers and total questions.
        /// Ignores the time taken to complete the quiz.
        /// </summary>
        /// <param name="correctAnswers">The number of questions answered correctly.</param>
        /// <param name="totalQuestions">The total number of questions in the quiz.</param>
        /// <param name="timeTaken">The time taken to complete the quiz (not used in this strategy).</param>
        /// <returns>The score as an integer percentage (0-100).</returns>
        public int CalculateScore(int correctAnswers, int totalQuestions, TimeSpan timeTaken)
        {
            // Calculate the percentage of correct answers.
            // Note: Integer division may result in loss of precision for non-perfect scores.
            return (correctAnswers / totalQuestions) * 100;
        }
    }

}
