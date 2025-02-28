﻿using System;

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
                }
                else
                {
                    response = "Sorry, I can't recognise your question, type it again.";
                }
                Console.WriteLine(response);
            }
        }
    }
}
