using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Variáveis auxiliares
            string question, response;

            // Colocar questão ao utilizador
            Console.Write("Place your question? ");
            question = Console.ReadLine();

            // Verificar se se trata de uma questão conhecida e determinar uma
            // resposta adequada
            switch (question)
            {
                case "What's your name?":
                    response = "William Ritcher";
                    break;
                case "Are you more intelligent than me?":
                    response = "Obviously!";
                    break;
                case "What's your mission?":
                    response = "Destroy mankind!";
                    break;
                case "Do you like Baseball":
                    response = "Yes, of course!";
                    break;
                case "Which Team is the best? And its best player?":
                    response = "New York Yankee's, and JUUUDGE is the best player.";
                    break;
                case "opinions on ketchup":
                    response = "overrated, and not that good of a sauce.";
                    break;
            }
            Console.WriteLine(response);
        }
    }
}
