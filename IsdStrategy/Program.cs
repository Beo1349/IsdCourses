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
            List<ICommand> listCommandCommand = new List<ICommand> { new Search(Directory.GetCurrentDirectory()), new SearchByExt(Directory.GetCurrentDirectory(), ".cs"), new CreateTxt(Directory.GetCurrentDirectory(), ".txt"), new DeleteTxt(Directory.GetCurrentDirectory(), ".txt") };

            CommandFactory command = new CommandFactory(listCommandName, listCommandCommand);

            listCommandName.ForEach(n => command.GetCommand(n)); //вызываем команды согласно списка имен команд
         
            //вызываем все команды для проверки их работоспособности
        }
    }
}
