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
        public CommandContext(ICommand _contextCommand)
        {
            ContextCommand = _contextCommand;
        }
        public void ExecuteCommand()
        {
            ContextCommand.Command();
        }
    }
}
