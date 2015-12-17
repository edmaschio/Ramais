using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domains.Domains;

namespace ConsoleRamais
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new ContextoRamais();

            var setor = new Setor { NomeSetor = "RH" };

        }
    }
}
