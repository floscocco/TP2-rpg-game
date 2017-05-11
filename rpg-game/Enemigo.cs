using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    class Enemigo
    {
        public Escenario mapa1;

        private int posicionX;
        private int posicionY;
        private int velocidad = 3;
        private int vida = 2;

        public Enemigo(int vida)
        {
            if (vida < 0)
            {
                Console.WriteLine("Enemigo eliminado");
            }
            else
            {
                if (vida > 2)
                {
                    Console.WriteLine("Vida del enemigo al maximo");
                }
            }
        }

        public Enemigo(int posicionX, int posicionY)
        {
            if (posicionX > mapa1.TamañoX || posicionX < 0 && posicionY > mapa1.TamañoY || posicionY < 0)
            {
                Console.WriteLine("Enemigo fuera del mapa");
            }
        }

        public void MoverX(int movimientoX)
        {
            PosicionX += movimientoX;
            Console.WriteLine("Step! " + "Posicion X Enemigo:" + PosicionX + " Posicion Y Enemigo:" + PosicionY);
        }

        public void MoverY(int movimientoY)
        {
            PosicionY += movimientoY;
            Console.WriteLine("Step! " + "Posicion X Enemigo:" + PosicionX + " Posicion Y Enemigo:" + PosicionY);
        }
        public void Morir()
        {
            Console.WriteLine("Enemigo eliminado");
            mapa1.Exp++;
            Console.WriteLine("Exp: " + mapa1.Exp);
        }

        public void Atacar()
        {
            Console.WriteLine("GRAR!");
        }

        public int PosicionX
        {
            get
            {
                return posicionX;
            }

            set
            {
                posicionX = value;
            }
        }

        public int PosicionY
        {
            get
            {
                return posicionY;
            }

            set
            {
                posicionY = value;
            }
        }

        public int Velocidad
        {
            get
            {
                return velocidad;
            }

            set
            {
                velocidad = value;
            }
        }

        public int Vida
        {
            get
            {
                return vida;
            }

            set
            {
                vida = value;
            }
        }
    }
}
