using StatePattern.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StateContext context = new StateContext();

            context.Request(5);
            context.Request(10);
            context.Request(15);

            Console.ReadKey();
        }
    }
}
