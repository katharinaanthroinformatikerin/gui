using GameLibrary.states;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{

    class Lended : IState
    {
        private Game _game;
        public Lended(Game game)
        {
            _game = game;
        }
        public bool Borrow()
        {
            Console.WriteLine("You already own the game!");
            return false;
        }

        public bool Download()
        {
            Console.WriteLine("You lended it away..");
            return false;
        }

        public bool GetBack()
        {
            Console.WriteLine("You got it back");
            _game.State = new Downloaded(_game);
            return true;
        }

        public string getName()
        {
            return "lended";
        }

        public bool Install()
        {
            Console.WriteLine("You do not have the game at the moment");
            return false;
        }

        public bool Lend()
        {
            Console.WriteLine("You do not have the game at the moment");
            return false;
        }

        public bool Play()
        {
            Console.WriteLine("You do not have the game at the moment");
            return false;
        }

        public bool Purchase()
        {
            Console.WriteLine("You already possess the game");
            return false;
        }

        public bool Refund()
        {
            Console.WriteLine("You cannot give it back at the moment");
            return false;
        }

        public bool Uninstall()
        {
            Console.WriteLine("That is not possible at the moment");
            return false;
        }

        public bool Update()
        {
            Console.WriteLine("That is not possible at the moment");
            return false;
        }
    }
}
