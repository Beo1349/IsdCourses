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
        public Dictionary<string,ICommand> ContextCommand { get; set; } //словарь команд
        public CommandContext(Dictionary<string, ICommand> _contextCommand)
        {
            ContextCommand = _contextCommand;
        }
        public void ExecuteCommand(string key, string path, string param = null)
        {
            ContextCommand[key].Command(path, param);
        }
    }
}
