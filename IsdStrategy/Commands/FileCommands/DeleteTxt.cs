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
        public void Command(string path, string param = null)
        {
            File.Delete(param + path + ".txt");
            Console.WriteLine("\n\nDelete in {0} file {1} ok!\n\n",path, param + path + ".txt");
        }
    }
}
