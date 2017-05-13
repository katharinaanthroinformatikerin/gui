using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class PurchaseCommand : ICommand
    {
        private Game _game;

        public PurchaseCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.Purchase();
        }
    }

    public class DownloadCommand : ICommand
    {
        private Game _game;

        public DownloadCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Download);
        }
    }
    public class InstallCommand : ICommand
    {
        private Game _game;

        public InstallCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Install);
        }
    }

    public class PlayCommand : ICommand
    {
        private Game _game;

        public PlayCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Play);
        }
    }

    public class UninstallCommand : ICommand
    {
        private Game _game;

        public UninstallCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Uninstall);
        }
    }

    public class UpdateCommand : ICommand
    {
        private Game _game;

        public UpdateCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Update);
        }
    }

    public class BorrowCommand : ICommand
    {
        private Game _game;

        public BorrowCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Borrow);
        }
    }

    public class LendCommand : ICommand
    {
        private Game _game;

        public LendCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Lend);
        }
    }

    public class GetBackCommand : ICommand
    {
        private Game _game;

        public GetBackCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.GetBack);
        }
    }

    public class RefundCommand : ICommand
    {
        private Game _game;
        public RefundCommand(Game game)
        {
            _game = game;
        }
        public void Execute()
        {
            _game.DoSomething(GameAction.Refund);
        }
    }
}
