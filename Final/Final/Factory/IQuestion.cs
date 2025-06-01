namespace Final.Factory
{
    public interface IQuestion
    {
        /// <summary>
        /// Returns the text of the question to be presented to the user.
        /// </summary>
        string GetQuestionText();

        /// <summary>
        /// Checks whether the provided answer is correct for this question.
        /// </summary>
        /// <param name="answer">The user's answer as a string.</param>
        /// <returns>True if the answer is correct; otherwise, false.</returns>
        bool CheckAnswer(string answer);
    }
}
