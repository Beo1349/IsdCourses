using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands.FileCommands
{
    class DeleteTxt : ICommand
    {
        protected string param { get; set; }
        protected string path { get; set; }
        public DeleteTxt(string _path, string _param)
        {
            param = _param; path = _path;
        }
        public void Command()
        {
            File.Delete(path + param);
            Console.WriteLine("\n\nDelete in {0} file {1} ok!\n\n",path, path + param);
        }
    }
}
