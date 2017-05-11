using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Escenario mapa = new Escenario();
            Jugador jug = new Jugador(5);
            Enemigo ene1 = new Enemigo(2);
            Enemigo ene2 = new Enemigo(2);
            Enemigo ene3 = new Enemigo(2);
            Random r = new Random();

            mapa.TamañoX = r.Next(500, 1000);
            mapa.TamañoY = r.Next(500, 1000);
            jug.PosicionX = mapa.TamañoX / 2;
            jug.PosicionY = mapa.TamañoY / 2;
            jug.mapa1 = mapa;

            Console.WriteLine("Iniciando partida");

            Console.WriteLine("Generando mapa");

            Console.WriteLine("Tamaño X del mapa:" + mapa.TamañoX);
            Console.WriteLine("Tamaño Y del mapa:" + mapa.TamañoY);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Generando jugador:");

            Console.WriteLine("Posicion X Jugador: " + jug.PosicionX + ", Vida: " + jug.Vida);
            Console.WriteLine("Posicion Y Jugador: " + jug.PosicionY);

            Console.WriteLine("-------------------------------------");

            ene1.mapa1 = mapa;
            ene2.mapa1 = mapa;
            ene3.mapa1 = mapa;
            ene1.PosicionX = mapa.TamañoX / 3;
            ene1.PosicionY = mapa.TamañoY / 3;
            ene2.PosicionX = mapa.TamañoX / 4;
            ene2.PosicionY = mapa.TamañoY / 4;
            ene3.PosicionX = mapa.TamañoX / 5;
            ene3.PosicionY = mapa.TamañoY / 5;

            Console.WriteLine("Generando enemigos:");

            Console.WriteLine("Posicion X Enemigo 1: " + ene1.PosicionX + ", Vida:" + ene1.Vida);
            Console.WriteLine("Posicion Y Enemigo 1: " + ene1.PosicionY);
            Console.WriteLine("Posicion X Enemigo 2: " + ene2.PosicionX + ", Vida:" + ene2.Vida);
            Console.WriteLine("Posicion Y Enemigo 2: " + ene2.PosicionY);
            Console.WriteLine("Posicion X Enemigo 3: " + ene3.PosicionX + ", Vida:" + ene3.Vida);
            Console.WriteLine("Posicion Y Enemigo 3: " + ene3.PosicionY);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Movimiento jugador:");

            jug.MoverX(3);
            jug.MoverY(3);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Ataque jugador:");

            jug.Atacar();

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Movimiento enemigos:");

            ene1.MoverX(3);
            ene1.MoverY(3);
            ene2.MoverX(3);
            ene2.MoverY(3);
            ene3.MoverX(3);
            ene3.MoverY(3);            

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Ataque enemigos:");

            ene1.Atacar();
            ene2.Atacar();
            ene3.Atacar();

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Muerte jugador:");

            jug.Morir();

            Console.WriteLine("-------------------------------------");

            Console.WriteLine("Muerte enemigos:");

            ene1.Morir();
            ene2.Morir();
            ene3.Morir();

            Console.ReadLine();


        }
    }
}
