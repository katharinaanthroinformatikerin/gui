using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.states
{
    public class Installed : IState
    {
        private Game _game;
        public Installed(Game game)
        {
            _game = game;
        }

        public bool Borrow()
        {
            Console.WriteLine("You borrowed a new game!");
            _game.State = new Downloaded(_game);
            return true;
        }

        public bool Download()
        {
            Console.WriteLine("Already downloaded!");
            return false;
        }

        public bool GetBack()
        {
            Console.WriteLine("You got your game back!");
            _game.State = new Installed(_game);
            return true;
        }

        public string getName()
        {
            return "installed";
        }

        public bool Install()
        {
            Console.WriteLine("Already installed!");
            return false;
        }

        public bool Lend()
        {
            Console.WriteLine("The game is not playable at the moment");
            _game.State = new Lended(_game);
            return true;
        }

        public bool Play()
        {
            Console.WriteLine("Have Fun!");
            return true;
        }

        public bool Purchase()
        {
            Console.WriteLine("You have already purchased it!");
            return false;
        }

        public bool Refund()
        {
            Uninstall();
            _game.State.Refund();
            return true;
        }

        public bool Uninstall()
        {
            Console.WriteLine("Uninstalling now...");
            _game.State = new Purchased(_game);
            return true;
        }

        public bool Update()
        {
            Console.WriteLine("Updating...");
            _game.State = new Downloaded(_game);
            return true;
        }
    }
}
