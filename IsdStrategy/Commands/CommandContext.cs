using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands
{
    class CommandContext 
    {
        ICommand ContextCommand;
        public CommandContext(object _contextCommand)
        {
            ContextCommand = (ICommand)_contextCommand;
        }
        public void ExecuteCommand()
        {
            try
            {
                ContextCommand.Command();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
