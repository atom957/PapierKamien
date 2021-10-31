using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapierKamienNozyce
{
    class Model
    {
        public int los_komputer()
        {
            Random rand = new Random();
            int ran = rand.Next(3);
            return ran;
        }
        public Type rozgrywka(int choice, int ran)
        {
            if (choice == (int)Type.STONE && ran == (int)Type.SCISSORS || choice == (int)Type.PAPER && ran == (int)Type.STONE || choice == (int)Type.SCISSORS && ran == (int)Type.PAPER)
            {
                return Type.wygrana;
            }
            else if (choice == ran)
            {
                return Type.remis;
            }
            else
            {
                return Type.przegrana;
            }
        }

        public enum Type : int
        {
            STONE = 0,
            PAPER = 1,
            SCISSORS = 2,
            wygrana = 0,
            przegrana = 1,
            remis = 3
        }
    }
}
