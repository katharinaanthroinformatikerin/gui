using GameLibrary.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Borrowed : IState
    {
        private Game _game;
        public Borrowed(Game game)
        {
            _game = game;
        }
        public bool Borrow()
        {
            Console.WriteLine("You already borrowed it");
            return false;
        }

        public bool Download()
        {
            Console.WriteLine("Downloading...");
            _game.State = new Downloaded(_game);
            return true;
        }

        public bool GetBack()
        {
            Console.WriteLine("That is not possible..");
            return false;
        }

        public string getName()
        {
            return "borrowed";
        }

        public bool Install()
        {
            Console.WriteLine("Installing..");
            _game.State = new Installed(_game);
            return true;
        }

        public bool Lend()
        {
            Console.WriteLine("That is not possible");
            return false;
        }

        public bool Play()
        {
            Console.WriteLine("Have fun!");
            _game.State.Play();
            return true;
        }

        public bool Purchase()
        {
            Console.WriteLine("You have to give it back first");
            return false;
        }

        public bool Refund()
        {
            Console.WriteLine("You do not own it silly!");
            return false;
        }

        public bool Uninstall()
        {
            Console.WriteLine("Removing");
            _game.State = new NotOwned(_game);
            return true;
        }

        public bool Update()
        {
            Console.WriteLine("Updating..");
            _game.State = new Downloaded(_game);
            return true;
        }
    }
}
