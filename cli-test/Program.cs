using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;

namespace AzureCliTest
{
    public static class Program
    {
        private static IEnumerable<Question> Questions;
        private static Queue<Question> Queue;
        private readonly static Random Random = new Random();

        public static void Main()
        {
            var questionsString = System.IO.File.ReadAllText("questions.json");

            Questions = JsonSerializer.Deserialize<IEnumerable<Question>>(questionsString);

            Console.WriteLine($@"
======================================================
Welcome to the Azure CLI Commands Practice Test!
There are {Questions.Count()} possible questions.
Once you complete them all, the test will restart
from the beginning again until you close the console.
======================================================
");

            while (true)
            {
                int score = 0;
                Queue = new Queue<Question>(
                    Questions.OrderBy(_ => Random.Next())
                );

                while (Queue.Count > 0)
                {
                    var question = Queue.Dequeue();

                    var isCorrect = PromptQuestion(question);

                    if (isCorrect) score++;
                }

                double percent = score / Questions.Count() * 100;

                Console.WriteLine($@"

================================================
Done!
You got {score} of {Questions.Count()} correct!
That's a {percent}%! A 70% is a passing grade!
================================================
");
            }
        }

        private static bool PromptQuestion(Question question)
        {
            Console.WriteLine("\nQ: {0}", question.Prompt);

            var response = Console.ReadLine();
            var isCorrect = question.CheckAnswer(response);

            if (isCorrect)
            {
                Console.Write(" ==> CORRECT!");
            }
            else
            {
                Console.Write(" ==> INCORRECT!");
                Console.Write($"Answer: `{string.Join(" ", question.Answer)}`");
            }

            return isCorrect;
        }
    }
}
