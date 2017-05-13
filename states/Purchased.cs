using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.states
{
    public class Purchased : IState
    {
        private Game _game;
        public Purchased(Game game)
        {
            _game = game;
        }

        public bool Borrow()
        {
            Console.WriteLine("You already posses the game!");
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
            Console.WriteLine("You have to lend it first!");
            return false;
        }

        public string getName()
        {
            return "purchased";
        }

        public bool Install()
        {
            Console.WriteLine("You have to download it first");
            return false;
        }

        public bool Lend()
        {
            Console.WriteLine("You give your game away..");
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
            Console.WriteLine("Your game is already up to date");
            return false;
        }
    }
}
