using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    class Program
    {
        private static bool quit = false;

        static void tmp(string[] args)
        {
            var game = new Game();
            ICommand purchase = new PurchaseCommand(game);
            ICommand download = new DownloadCommand(game);
            ICommand install = new InstallCommand(game);
            ICommand play = new PlayCommand(game);
            ICommand refund = new RefundCommand(game);
            ICommand uninstall = new UninstallCommand(game);
            ICommand update = new UpdateCommand(game);
            ICommand lend = new LendCommand(game);
            ICommand borrow = new BorrowCommand(game);
            ICommand getBack = new GetBackCommand(game);
            Execute e = new Execute();
            bool runNow = true;
            //game.DoSomething(GameAction.Purchase);

            //game.DoSomething(GameAction.Play);
            Console.WriteLine("Welcome to Program.cs");
            while(!quit)
                switch(Console.ReadLine())
                {
                    case "purchase":
                        e.Store(purchase, runNow);
                        Console.WriteLine();
                        break;
                    case "download":
                        e.Store(download, runNow);
                        Console.WriteLine();
                        break;
                    case "install":
                        e.Store(install, runNow);
                        Console.WriteLine();
                        break;
                    case "play":
                        e.Store(play, runNow);
                        Console.WriteLine();
                        break;
                    case "refund":
                        e.Store(refund, runNow);
                        Console.WriteLine();
                        break;
                    case "uninstall":
                        e.Store(uninstall, runNow);
                        Console.WriteLine();
                        break;
                    case "update":
                        e.Store(update, runNow);
                        Console.WriteLine();
                        break;
                    case "lend":
                        e.Store(lend, runNow);
                        Console.WriteLine();
                        break;
                    case "borrow":
                        e.Store(borrow, runNow);
                        Console.WriteLine();
                        break;
                    case "getBack":
                        e.Store(getBack, runNow);
                        Console.WriteLine();
                        break;
                    case "run mode":
                        Console.WriteLine("you can now run commands");
                        runNow = true;
                        break;
                    case "store mode":
                        Console.WriteLine("you can now store commands - type run to execute");
                        runNow = false;
                        break;
                    case "run":
                        e.RunAll();
                        Console.WriteLine();
                        break;
                    case "exit":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("You typed something wrong");
                        Console.WriteLine();
                        Console.ReadLine();
                        break;
                }

            Console.WriteLine("bye bye");
            Console.ReadKey();
        }
    }
}
