using IsdStrategy.Commands;
using IsdStrategy.Commands.FileCommands;
using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy
{

    class Program
    {
        static void Main(string[] args)
        {
            CommandFactory commandFactory = new CommandFactory();

            CommandContext command = new CommandContext(commandFactory.create_Type("Search")); //поиск
            command.ExecuteCommand();

            command = new CommandContext(commandFactory.create_Type("SearchByExt")); //поиск по расширению
            command?.ExecuteCommand();

            command = new CommandContext(commandFactory.create_Type("CreateTxt")); //создание текстовика
            command?.ExecuteCommand();

            command = new CommandContext(commandFactory.create_Type("DeleteTxt")); //удаление тектовика
            command?.ExecuteCommand();

        }
    }
}
