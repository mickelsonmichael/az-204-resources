using System;
using System.Collections.Generic;
using System.Linq;

namespace AzureCliTest
{
    public class Question
    {
        public string Prompt { get; set; }
        public IEnumerable<string> Answer { get; set; }

        public bool CheckAnswer(string response)
        {
            var responseParts = response.Split(" ");

            if (Answer.Count() != responseParts.Length)
                return false;

            for (int i = 0; i < Math.Min(Answer.Count(), responseParts.Length); i++)
            {
                var expected = Answer.ElementAt(i);
                var actual = responseParts[i];

                if (!string.Equals(actual, expected))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
