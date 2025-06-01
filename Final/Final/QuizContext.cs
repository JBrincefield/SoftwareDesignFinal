using Final.Factory;
using Final.Strategy;

namespace Final
{
    /// <summary>
    /// Manages the quiz flow, including question handling and scoring.
    /// </summary>
    public class QuizContext
    {
        // List of quiz questions implementing IQuestion interface
        private List<IQuestion> _questions;
        // Scoring strategy implementing IScoringStrategy interface
        private IScoringStrategy _scoringStrategy;

        /// <summary>
        /// Initializes a new instance of QuizContext with a given scoring strategy.
        /// </summary>
        /// <param name="scoringStrategy">Strategy used to calculate the final score.</param>
        public QuizContext(IScoringStrategy scoringStrategy)
        {
            _questions = new List<IQuestion>();
            _scoringStrategy = scoringStrategy;
        }

        /// <summary>
        /// Adds a question to the quiz.
        /// </summary>
        /// <param name="question">The question to add.</param>
        public void AddQuestion(IQuestion question)
        {
            _questions.Add(question);
        }

        /// <summary>
        /// Starts the quiz, prompts user for answers, and displays the final score.
        /// </summary>
        public void StartQuiz()
        {
            int correct = 0;
            var start = DateTime.Now;

            // Iterate through all questions
            foreach (var q in _questions)
            {
                Console.WriteLine(q.GetQuestionText());
                Console.Write("Your Answer: ");
                string answer = Console.ReadLine();

                // Check if the answer is correct
                if (q.CheckAnswer(answer))
                {
                    Console.WriteLine("Correct!\n");
                    correct++;
                }
                else
                {
                    Console.WriteLine("Wrong.\n");
                }
            }

            var duration = DateTime.Now - start;
            // Calculate the final score using the selected scoring strategy
            int finalScore = _scoringStrategy.CalculateScore(correct, _questions.Count, duration);

            Console.WriteLine($"Quiz Complete. Your Score: {finalScore}");
        }
    }
}
