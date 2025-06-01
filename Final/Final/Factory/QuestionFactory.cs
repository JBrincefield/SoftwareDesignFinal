using System;
using System.Collections.Generic;

namespace Final.Factory
{
    /// <summary>
    /// Factory class for creating random quiz questions (MCQ or True/False).
    /// </summary>
    public class QuestionFactory
    {
        // List of predefined multiple-choice questions
        private readonly List<MCQQuestion> mcqQuestions;
        // List of predefined true/false questions
        private readonly List<TrueFalseQuestion> tfQuestions;
        // Random number generator for selecting questions
        private readonly Random random;

        /// <summary>
        /// Initializes the question factory with a set of MCQ and True/False questions.
        /// </summary>
        public QuestionFactory()
        {
            random = new Random();

            mcqQuestions = new List<MCQQuestion>
                {
                    new MCQQuestion { Question = "What is the capital of France?", Options = new[] { "Paris", "London", "Berlin", "Rome" }, CorrectOption = "Paris" },
                    new MCQQuestion { Question = "Which planet is known as the Red Planet?", Options = new[] { "Mars", "Venus", "Jupiter", "Saturn" }, CorrectOption = "Mars" },
                    new MCQQuestion { Question = "What is the largest ocean on Earth?", Options = new[] { "Atlantic", "Indian", "Pacific", "Arctic" }, CorrectOption = "Pacific" },
                    new MCQQuestion { Question = "Who wrote 'Hamlet'?", Options = new[] { "Shakespeare", "Dickens", "Austen", "Orwell" }, CorrectOption = "Shakespeare" },
                    new MCQQuestion { Question = "What is the boiling point of water?", Options = new[] { "100C", "0C", "50C", "212C" }, CorrectOption = "100C" },
                    new MCQQuestion { Question = "Which element has the chemical symbol 'O'?", Options = new[] { "Oxygen", "Gold", "Silver", "Iron" }, CorrectOption = "Oxygen" },
                    new MCQQuestion { Question = "What is the square root of 64?", Options = new[] { "8", "6", "7", "9" }, CorrectOption = "8" },
                    new MCQQuestion { Question = "Which country hosted the 2016 Summer Olympics?", Options = new[] { "Brazil", "China", "UK", "Russia" }, CorrectOption = "Brazil" },
                    new MCQQuestion { Question = "What is the chemical formula for water?", Options = new[] { "H2O", "CO2", "O2", "NaCl" }, CorrectOption = "H2O" },
                    new MCQQuestion { Question = "Who painted the Mona Lisa?", Options = new[] { "Leonardo da Vinci", "Picasso", "Van Gogh", "Rembrandt" }, CorrectOption = "Leonardo da Vinci" }
                };

            tfQuestions = new List<TrueFalseQuestion>
                {
                    new TrueFalseQuestion { Question = "C# is a statically typed language.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "The sun rises in the west.", CorrectAnswer = false },
                    new TrueFalseQuestion { Question = "Water freezes at 0C.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "The capital of Italy is Rome.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "Bats are mammals.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "The Great Wall of China is visible from space.", CorrectAnswer = false },
                    new TrueFalseQuestion { Question = "Light travels faster than sound.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "Mount Everest is the tallest mountain in the world.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "The chemical symbol for gold is Au.", CorrectAnswer = true },
                    new TrueFalseQuestion { Question = "Penguins can fly.", CorrectAnswer = false }
                };
        }

        /// <summary>
        /// Creates and returns a random question of the specified type.
        /// </summary>
        /// <param name="type">The type of question to create ("MCQ" or "TF").</param>
        /// <returns>An IQuestion instance representing the selected question.</returns>
        /// <exception cref="ArgumentException">Thrown if the question type is invalid.</exception>
        public IQuestion CreateQuestion(string type)
        {
            if (type == "MCQ")
            {
                // Select a random MCQ question
                int index = random.Next(mcqQuestions.Count);
                return mcqQuestions[index];
            }
            else if (type == "TF")
            {
                // Select a random True/False question
                int index = random.Next(tfQuestions.Count);
                return tfQuestions[index];
            }
            throw new ArgumentException("Invalid question type");
        }
    }
}
