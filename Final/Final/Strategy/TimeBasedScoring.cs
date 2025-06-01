namespace Final.Strategy
{
    /// <summary>
    /// Implements a time-based scoring strategy for quizzes.
    /// The score is calculated based on the number of correct answers,
    /// total questions, and the time taken to complete the quiz.
    /// </summary>
    public class TimeBasedScoring : IScoringStrategy
    {
        /// <summary>
        /// Calculates the score using both accuracy and speed.
        /// </summary>
        /// <param name="correctAnswers">Number of correct answers.</param>
        /// <param name="totalQuestions">Total number of questions.</param>
        /// <param name="timeTaken">Time taken to complete the quiz.</param>
        /// <returns>
        /// The total score, which is the sum of the base score (accuracy)
        /// and a time bonus (speed).
        /// </returns>
        public int CalculateScore(int correctAnswers, int totalQuestions, TimeSpan timeTaken)
        {
            // Base score: percentage of correct answers (0-100)
            int baseScore = (correctAnswers / totalQuestions) * 100;

            // Time bonus: more points for faster completion, up to (totalQuestions * 10)
            int timeBonus = (int)((totalQuestions * 10) - timeTaken.TotalSeconds);

            // Total score is the sum of base score and time bonus
            return baseScore + timeBonus;
        }
    }

}
