using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands.FileCommands
{
    class Search : ICommand
    {
        public void Command(string path, string param = null)
        {
            Directory.GetFiles(path).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("\n\nSearch in {0} ok!\n\n", path);
        }
    }
}
