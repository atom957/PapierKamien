using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapierKamienNozyce
{
    class Controler
    {
        Model model = new Model();
        View view = new View();
        public void polonczenie()
        {
            int t = 0;
            int k = 0;
            while (t != 3 && k != 3)
            {
                int e = view.wybur();
                int w = model.los_komputer();
                Model.Type i = model.rozgrywka(e, w);
                view.wynik(i, w, e);
                if (i == Model.Type.wygrana)
                {
                    t += 1;
                }
                else if(i == Model.Type.przegrana)
                {
                    k += 1;
                }
                Console.WriteLine(t);
                Console.WriteLine(k);
            }
        }
    }
}
