using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion4.Controller;

namespace Lektion4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exempel 1:   Gör en program-loop som frågar användaren om hen vill lista användare (list)
            //              eller avsluta (exit). Skapa lösningen mha MVC-mönstret.
            bool exit = false;
            DefaultController defaultController = new DefaultController();
            string input;
            while (!exit)
            {
                Console.WriteLine("Enter command + [enter] (? for help):");

                input = Console.ReadLine();

                var resultView = defaultController.handleInput(input);

                Console.WriteLine(resultView.Render());

                if (defaultController.Exit)
                    exit = true;
            }
        }
    }
}
