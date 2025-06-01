using Final.Factory;

namespace Final.Proxy
{
    /// <summary>
    /// Proxy class for IQuestion that controls access to question content and answer checking.
    /// </summary>
    public class QuestionProxy : IQuestion
    {
        // The real question object being proxied
        private IQuestion _Question;
        // Indicates whether the user has access to the question
        private bool _hasAccess;

        /// <summary>
        /// Initializes a new instance of the QuestionProxy class.
        /// </summary>
        /// <param name="realQuestion">The actual question object to proxy.</param>
        /// <param name="hasAccess">Whether the user has access to the question.</param>
        public QuestionProxy(IQuestion realQuestion, bool hasAccess)
        {
            _Question = realQuestion;
            _hasAccess = hasAccess;
        }

        /// <summary>
        /// Returns the question text if access is granted; otherwise, returns an access denied message.
        /// </summary>
        public string GetQuestionText()
        {
            return _hasAccess ? _Question.GetQuestionText() : "This is a premium question. Access Denied.";
        }

        /// <summary>
        /// Checks the answer if access is granted; otherwise, always returns false.
        /// </summary>
        public bool CheckAnswer(string answer)
        {
            return _hasAccess && _Question.CheckAnswer(answer);
        }
    }

}
