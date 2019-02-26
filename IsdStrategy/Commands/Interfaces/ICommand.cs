using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy.Commands.Interfaces
{
    interface ICommand
    {
        void Command(string path, string param);
    }
}
