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
        //что если совсем убрать параметры для метода, а все необходимое передавать в конструктор класа в фабрике? Тогда у нас не будет проблем с выбором передааваемых параметров.
    }
}
