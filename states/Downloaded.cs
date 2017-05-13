using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.states
{
    public class Downloaded : IState
    {
        private Game _game;
        
        public Downloaded(Game game)
        {
            _game = game;
        }

        public bool Borrow()
        {
            Console.WriteLine("You got a new game");
            _game.State = new Downloaded(_game);
            return true;
        }

        public bool Download()
        {
            Console.WriteLine("Downloading...");
            return true;
        }

        public bool GetBack()
        {
            Console.WriteLine("You got your game back");
            _game.State = new Installed(_game);
            return true;
        }

        public string getName()
        {
            return "downloaded";
        }

        public bool Install()
        {
            Console.WriteLine("Installing...");
            _game.State = new Installed(_game);
            return true;
        }

        public bool Lend()
        {
            Console.WriteLine("You gave your game away");
            _game.State = new Lended(_game);
            return true;
        }

        public bool Play()
        {
            Install();
            _game.State.Play();
            return true;
        }

        public bool Purchase()
        {
            Console.WriteLine("You have already bought it!");
            return false;
        }

        public bool Refund()
        {
            Console.WriteLine("You get your money back!");
            _game.State = new NotOwned(_game);
            return true;
        }

        public bool Uninstall()
        {
            Console.WriteLine("Not installed!");
            return false;
        }

        public bool Update()
        {
            Console.WriteLine("Updating..");
            _game.State = new Downloaded(_game);
            return true;
        }
    }
}
