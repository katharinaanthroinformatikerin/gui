using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameLibrary;

namespace GameLibary
{
    class GameController
    {
        public Dictionary<string, Game> Games  { get; }

        public GameController()
        {
            Games = new Dictionary<string, Game>();
            Game spaceInvaders = new Game();
            spaceInvaders.Name = "Space Invaders";
            Games.Add(spaceInvaders.Name, spaceInvaders);

            Game geisterstunde = new Game();
            geisterstunde.Name = "Geisterstunde";
            Games.Add(geisterstunde.Name, geisterstunde);

            Game mäuserennen = new Game();
            mäuserennen.Name = "Mäuserennen";
            Games.Add(mäuserennen.Name, mäuserennen);
        }


    }
}
