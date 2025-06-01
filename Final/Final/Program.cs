using Final;
using Final.Factory;
using Final.Proxy;
using Final.Strategy;

class Program
{
    static void Main(string[] args)
    {
        // Prompt user to select a scoring method
        Console.WriteLine("Choose Scoring Method: 1. Standard  2. Time-Based");
        string choice = Console.ReadLine();

        // Select scoring strategy based on user input
        IScoringStrategy strategy = choice == "2" ? new TimeBasedScoring() : new StandardScoring();
        QuizContext quiz = new QuizContext(strategy);

        // Create a question factory to generate questions
        QuestionFactory factory = new QuestionFactory();

        // Create standard questions using the factory
        var q1 = factory.CreateQuestion("MCQ");
        var q2 = factory.CreateQuestion("TF");

        // Prompt user for password to access the premium question
        Console.WriteLine("What is the password to the Premium question");
        string password = Console.ReadLine();

        // Check if the user has access to the premium question
        bool hasAccess = password == "Premium1@3";
        // Create a premium question wrapped in a proxy to control access
        var premiumQuestion = new QuestionProxy(factory.CreateQuestion("MCQ"), hasAccess);

        // Add questions to the quiz context
        quiz.AddQuestion(q1);
        quiz.AddQuestion(q2);
        quiz.AddQuestion(premiumQuestion);

        // Start the quiz
        quiz.StartQuiz();
    }
}
