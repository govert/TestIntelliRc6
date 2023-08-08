using ExcelDna.Integration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntelliRc6
{
    public static class Functions
    {
        [ExcelFunction("Simple hello function")]
        public static string SayHello(string name) => $"Hello {name}!";
    }
}
