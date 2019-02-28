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
        protected string param { get; set; }
        protected string path { get; set; }
        public Search()
        {
            param = null; path = Directory.GetCurrentDirectory();
        }
        public void Command()
        {
            Directory.GetFiles(path).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("\n\nSearch in " + path + " ok!\n\n");
        }
    }
}
