using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_Del_Interior
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opciones, cantidad, precio, vendedor;
            int i, j;
            int tipo1 = 0, tipo2 = 0, tipo3 = 0;
            int recarton1 = 0, recarton2 = 0, recarton3 = 0, rectotal = 0;

            do
            {
                Console.WriteLine("Ingrese la cantidad de vendedores (Entre 2 a 4)");
                vendedor = Convert.ToInt32(Console.ReadLine());
            } while (vendedor < 2 && vendedor > 4);

            for (i = 1; i <= vendedor; i++)
            {
                do
                {
                    Console.WriteLine("Vendedor " + i + ": Cuantos cartones quiere comprar (Entre 1 a 10)");
                    cantidad = Convert.ToInt32(Console.ReadLine());
                } while (cantidad < 1 && cantidad > 10);

                for (j = 1; j <= cantidad; j++)
                {
                    Console.WriteLine("Que carton va a comprar ? ");
                    Console.WriteLine("1_ Tele Bingo ($400)");
                    Console.WriteLine("2_ Quini Seis ($800)");
                    Console.WriteLine("3_ Toto Bingo ($750)");
                    opciones = Convert.ToInt32(Console.ReadLine());

                    switch (opciones)
                    {
                        case 1:
                            tipo1 += 1;
                            recarton1 += 400;
                            break;
                        case 2:
                            tipo2 += 1;
                            recarton2 += 800;
                            break;
                        case 3:
                            tipo3 += 1;
                            recarton3 += 750;
                            break;
                    }
                }
            }
            rectotal = recarton1 + recarton2 + recarton3;

            Console.WriteLine("Recaudacion Total : $" + rectotal);
            Console.WriteLine("Recaudacion Tele Bingo (Carton 1): $" + recarton1 + " <- Vendidos: " + tipo1);
            Console.WriteLine("Recaudacion Tele Bingo (Carton 2): $" + recarton2 + " <- Vendidos: " + tipo2);
            Console.WriteLine("Recaudacion Tele Bingo (Carton 3): $" + recarton3 + " <- Vendidos: " + tipo3);
        }
    }
}
