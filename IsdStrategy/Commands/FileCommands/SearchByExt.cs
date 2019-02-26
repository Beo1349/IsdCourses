using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands.FileCommands
{
    class SearchByExt : ICommand
    {
        public void Command(string path, string param)
        {
            if (param == null) param = ".cs";
            Directory.GetFiles(path, "*" + param).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("\n\nSearch in {0} by {1} ok!\n\n",path, param);
        }
    }
}
