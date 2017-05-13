using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class Execute
    {
        private List<ICommand> commands = new List<ICommand>();

        public void Run(ICommand command)
        {
            command.Execute();
        }

        public void Store(ICommand command, bool runNow=false)
        {
            if (runNow)
                Run(command);
            else
            {
                commands.Add(command);
                Console.WriteLine("Command has been stored!");
            }
        }
        public void RunAll()
        {
            commands.ForEach(p => p.Execute());
            commands.Clear();
        }
    }
}
