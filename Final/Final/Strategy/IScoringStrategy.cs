namespace Final.Strategy
{
    public interface IScoringStrategy
    {
        /// <summary>
        /// Calculates the score for a quiz attempt based on the number of correct answers,
        /// total number of questions, and the time taken to complete the quiz.
        /// </summary>
        /// <param name="correctAnswers">The number of questions answered correctly.</param>
        /// <param name="totalQuestions">The total number of questions in the quiz.</param>
        /// <param name="timeTaken">The time taken to complete the quiz.</param>
        /// <returns>The calculated score as an integer.</returns>
        int CalculateScore(int correctAnswers, int totalQuestions, TimeSpan timeTaken);
    }

}
