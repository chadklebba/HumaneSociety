using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLCommand command = new SQLCommand();
            HSMain main = new HSMain();
            main.RunProgram();
        }
    }
}
