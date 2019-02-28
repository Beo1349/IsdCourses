using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands.FileCommands
{
    class CreateTxt : ICommand
    {
        protected string param { get; set; }
        protected string path { get; set; }
        public CreateTxt()
        {
            param = ".txt"; path = Directory.GetCurrentDirectory();
        }
        public void Command()
        {
            if (!File.Exists(path + param))
                File.Create(path + param).Dispose(); //нужен Dispose, т.к. после создания файл занят
            Console.WriteLine("\n\nCreating in " + path + " by " + param + " ok!\n\n");
        }
    }
}
