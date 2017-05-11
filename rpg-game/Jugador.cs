using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    class Jugador
    {
        public Escenario mapa1;

        private int posicionX;
        private int posicionY;
        private int velocidad = 3;
        private int vida = 5;

        public Jugador(int vida)
        {
            if (vida < 0)
            {
                Console.WriteLine("Game Over");
            }
            else
            {
                if (vida > 5)
                {
                    Console.WriteLine("Vida al maximo");
                }
            }
        }

        public Jugador(int posicionX, int posicionY)
        {
            if (posicionX > mapa1.TamañoX || posicionX < 0 && posicionY > mapa1.TamañoY || posicionY < 0)
            {
                Console.WriteLine("Jugador fuera del mapa");
            }
        }

        public void MoverX(int movimientoX)
        {
            PosicionX += movimientoX;
            Console.WriteLine("Step! " + "Posicion X Jugador:" + PosicionX + " Posicion Y Jugador:" + PosicionY);
        }

        public void MoverY(int movimientoY)
        {
            PosicionY += movimientoY;
            Console.WriteLine("Step! " + "Posicion X Jugador:" + PosicionX + " Posicion Y Jugador:" + PosicionY);
        }

        public void Morir()
        {
            Console.WriteLine("Game Over");
        }

        public void Atacar()
        {
            Console.WriteLine("Hah!");
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
