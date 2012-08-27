using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lektion4.Model.Repository;
using Lektion4.View;
using Lektion4.Model;

namespace Lektion4.Controller
{
    public class DefaultController
    {
        private Repository Repo = new Repository();
        public bool Exit { get; set; }

        public ListView handleInput(string Input) {
            switch (Input)
            {
                case "?":
                case "help":
                    return new ListView("\n\nAvailable Commands:\n\thelp/?:\thelp\n\tlist:\tList Users\n\texit:\tExit Program");
                case "list":
                    List<User> users = Repo.GetUsers().Take(10).ToList();
                    return new ListView(users);
                case "exit":
                    Exit = true;
                    return new ListView("Exiting Program!");
                default:
                    return new ListView("Error! Cannot parse input!");
            }
        }
    }
}
