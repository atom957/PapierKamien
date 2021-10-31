using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapierKamienNozyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Controler controler = new Controler();
            controler.polonczenie();

            Console.ReadKey();
        }
    }
}
