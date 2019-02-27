using IsdStrategy.Commands;
using IsdStrategy.Commands.FileCommands;
using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy
{
    class CommandFactory
    {
        public Dictionary<string, ICommand> dic { get; set; }
        private CommandContext con;
        public CommandFactory(List<string> listCommandName, List<ICommand> listCommandCommand)
        {
            dic = new Dictionary<string, ICommand>();
            listCommandName.ForEach(n => dic.Add(n, listCommandCommand[listCommandName.IndexOf(n)])); //заполняет словарь сопоставляя одинаковые индексы имени и команды
        }
        public void GetCommand(string key)
        {
            con = new CommandContext(dic[key]); //передает обьект из словаря в соответсвии с ключом в конструктор контекста
            con.ExecuteCommand();
        }
    }
}
