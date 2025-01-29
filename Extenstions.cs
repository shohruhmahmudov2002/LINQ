using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public static class Extenstions
    {
        public static void ToConsole(this IEnumerable<object> collection)
        {
            Console.WriteLine(string.Join(", ", collection));
        }
    }
}
