using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnumTest;

namespace EnumConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            var entities = context.Entities.Count();
            Console.WriteLine("entities: {0}", entities);
            Console.ReadLine();
        }
    }
}
