using IsdStrategy.Commands;
using IsdStrategy.Commands.FileCommands;
using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
             List<string> listCommandName = new List<string> { "Search", "SearchByExt", "CreateTxt", "DeleteTxt" }; 
            List<ICommand> listCommandCommand = new List<ICommand> { new Search(), new SearchByExt(), new CreateTxt(), new DeleteTxt() };
            Dictionary<string, ICommand> dic = new Dictionary<string, ICommand>();
            listCommandName.ForEach(n => dic.Add(n, listCommandCommand[listCommandName.IndexOf(n)])); //заполняет словарь сопоставляя одинаковые индексы имени и команды
            CommandContext commandContext = new CommandContext(dic);

            listCommandName.ForEach(n => commandContext.ExecuteCommand(n, Directory.GetCurrentDirectory())); //вызываем команды согласно списка имен команд
         
        }
    }
}
