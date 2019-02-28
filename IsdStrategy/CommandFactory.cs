using IsdStrategy.Commands;
using IsdStrategy.Commands.FileCommands;
using IsdStrategy.Commands.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy
{
    class CommandFactory
    {
        public Dictionary<string, Type> dic = new Dictionary<string, Type>();
        public CommandFactory()
        {
            var AssemblyTypes = from t in Assembly.GetExecutingAssembly().GetTypes()
                               where t.GetInterfaces().Contains(typeof(ICommand))
                               select t;
            AssemblyTypes.ToList().ForEach(s => register_Type(s));
        }
        public void register_Type(Type t)
        {
            dic.Add(t.Name, t);            
        }
        public object create_Type(string Name)
        {
            try
            {
                return Activator.CreateInstance(dic[Name]);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}
