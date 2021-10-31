using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapierKamienNozyce
{
    class View
    {
        public int wybur()
        {
            Console.WriteLine("wpisz wybur:");
            return int.Parse(Console.ReadLine());
        }

        public void wynik(Model.Type w, int wk, int e)
        {
            if (e == 0)
            {
                Console.WriteLine("wybur gracza kamień");
            }
            else if (e == 1)
            {
                Console.WriteLine("wybur gracza papier");
            }
            else
            {
                Console.WriteLine("wybur gracza nozyce");
            }
            if (wk == 0)
            {
                Console.WriteLine("wybur komputera kamień");
            }
            else if (wk == 1)
            {
                Console.WriteLine("wybur komputera papier");
            }
            else
            {
                Console.WriteLine("wybur komputera nozyce");
            }



            if (w == Model.Type.wygrana)
            {
                Console.WriteLine("wygrales");
            }
            else if(w == Model.Type.remis)
            {
                Console.WriteLine("remis");
            }
            else
            {
                Console.WriteLine("przegrales");
            }
        }
    }
}
