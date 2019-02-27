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
        protected string param { get; set; }
        protected string path { get; set; }
        public SearchByExt(string _path, string _param)
        {
            param = _param; path = _path;
        }
        public void Command()
        {
            if (param == null) param = ".cs";
            Directory.GetFiles(path, "*" + param).ToList().ForEach(p => Console.WriteLine(p));
            Console.WriteLine("\n\nSearch in " + path + " by " + param + " ok!\n\n");
        }
    }
}
