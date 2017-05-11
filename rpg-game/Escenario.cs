using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    class Escenario
    {
        private int tamañoX;
        private int tamañoY;
        private int exp = 0;

        public int TamañoX
        {
            get
            {
                return tamañoX;
            }

            set
            {
                tamañoX = value;
            }
        }

        public int TamañoY
        {
            get
            {
                return tamañoY;
            }

            set
            {
                tamañoY = value;
            }
        }

        public int Exp
        {
            get
            {
                return exp;
            }

            set
            {
                exp = value;
            }
        }
    }
}
