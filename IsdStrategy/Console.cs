using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsdStrategy
{
        static class Console //логирование в файл txt
        {
            static readonly string _logPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            public static void WriteLine()
            {
                File.AppendAllText(_logPath, Environment.NewLine + " " + DateTime.Now);
                System.Console.WriteLine();
            }

            public static void WriteLine(string line)
            {
                File.AppendAllText(_logPath, line + Environment.NewLine + " " + DateTime.Now);
                System.Console.WriteLine(line);
            }

            public static void Write(string line)
            {
                File.AppendAllText(_logPath, line + " " + DateTime.Now);
                System.Console.Write(line);
            }

            public static void Write(int n)
            {
                File.AppendAllText(_logPath, n.ToString() + " " + DateTime.Now);
                System.Console.Write(n);
            }
        }
}
