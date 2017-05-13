using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.states
{

    public class NotOwned : IState
    {
        private Game _game;
        public NotOwned(Game game)
        {
            _game = game;
        }

        public bool Borrow()
        {
            Console.WriteLine("You borrowed a new game!");
            _game.State = new Borrowed(_game);
            return true;
        }

        public bool Download()
        {
            Console.WriteLine("You have to buy and install it first");
            return false;
        }

        public bool GetBack()
        {
            Console.WriteLine("You cannot get back a game you do not own..");
            return false;
        }

        public string getName()
        {
            return "notOwned";
        }

        public bool Install()
        {
            Console.WriteLine("You have to buy it first");
            return false;
        }

        public bool Lend()
        {
            Console.WriteLine("You cannot lend a game you do not own...");
            return false;
        }

        public bool Play()
        {
            Console.WriteLine("You have to buy it first");
            return false;
        }

        public bool Purchase()
        {
            Console.WriteLine("You got a new game!");
            _game.State = new Purchased(_game);
            return true;
        }

        public bool Refund()
        {
            Console.WriteLine("You have to buy it first");
            return false;
        }

        public bool Uninstall()
        {
            Console.WriteLine("You have to buy it first");
            return false;
        }

        public bool Update()
        {
            Console.WriteLine("You have to purchase it first!");
            return false;
        }
    }
}
