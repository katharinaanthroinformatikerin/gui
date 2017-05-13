using GameLibrary.states;
using System;

namespace GameLibrary
{
    public enum GameAction
    {
        Purchase,
        Download,
        Install,
        Play,
        Refund,
        Uninstall,
        Update,
        Lend,
        Borrow,
        GetBack
    }
    public class Game
    {
        public IState State { get; set; }
        public string Name;

        public Game()
        {
            this.State = new NotOwned(this);
        }

        public void Purchase()
        {
            if(!State.Purchase())
            {
                Console.WriteLine("Something bad has happened!");
            }
            
        }
        public void DoSomething(GameAction action)
        {
            bool success = false;
            switch (action)
            {
                case GameAction.Purchase:
                    success = State.Purchase();
                    break;
                case GameAction.Install:
                    success = State.Install();
                    break;
                case GameAction.Play:
                    success = State.Play();
                    break;
                case GameAction.Refund:
                    success = State.Refund();
                    break;
                case GameAction.Uninstall:
                    success = State.Uninstall();
                    break;
                case GameAction.Download:
                    success = State.Download();
                    break;
                case GameAction.Update:
                    success = State.Update();
                    break;
                case GameAction.Lend:
                    success = State.Lend();
                    break;
                case GameAction.Borrow:
                    success = State.Borrow();
                    break;
                case GameAction.GetBack:
                    success = State.GetBack();
                    break;
            }
            //if (!success)
               // Console.WriteLine("Something bad has happened!");
        }
    }
}
