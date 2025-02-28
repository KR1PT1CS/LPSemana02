using System;

namespace ChatGPTOne

{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello LP1!");
            while (true)
            {
                Console.Write("Place your question (EXIT to leave): ");
                string question = Console.ReadLine();
                string response;

                if (question.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
                {
                    response = "Goodbye!";
                    Console.WriteLine(response);
                    break;
                }
                if (question == "What's your name?")
                {
                    response = "My name is ChatGPTOne.";
                }
                else if (question == "How are you?")
                {
                    response = "I'm fine, thanks for asking!";
                    
                case "Do you like Baseball":
                    response = "Yes, of course!";
                    break;
                case "Which Team is the best? And its best player?":
                    response = "New York Yankee's, and JUUUDGE is the best player.";
                    break;
                case "opinions on ketchup":
                    response = "overrated, and not that good of a sauce.";
                    break;
                    response = "Sorry, I can't recognise your question, type it again.";
                }
                Console.WriteLine(response);
            }
        }
    }
}