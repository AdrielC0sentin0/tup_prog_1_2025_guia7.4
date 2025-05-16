using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_7._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int encuestadores, i, j, personas;
            int bici, moto, auto, publico, opciones;

            bici = 0;
            auto = 0;
            publico = 0;
            moto = 0;

            do
            {
                Console.WriteLine("Ingrese la cantidad de encuestadores (Entre 2 a 4)");
                encuestadores = Convert.ToInt32(Console.ReadLine());
            }
            while (encuestadores > 2 && encuestadores < 4);

            for (i =1; i <= encuestadores; i++)
            {
                Console.WriteLine("Encuestador "+ i);
                Console.WriteLine("Cuantas personas vas a encuestar");
                personas = Convert.ToInt32(Console.ReadLine());

                for (j = 1; j<= personas; j++)
                {
                    Console.WriteLine("Persona " + j + ": Que medio de transporte usas mas ?");
                    Console.WriteLine("1- Bicicleta");
                    Console.WriteLine("2- Motocicleta");
                    Console.WriteLine("3- Automovil");
                    Console.WriteLine("4- Transporte Publico");
                    opciones = Convert.ToInt32(Console.ReadLine());

                    switch (opciones)
                    {
                        case 1:
                            bici = bici + 1;
                            break;
                        case 2:
                            moto = moto + 1;
                            break;
                        case 3:
                            auto = auto + 1;
                            break;
                        case 4:
                            publico = publico + 1;
                            break;
                    }
                }
            }
            Console.WriteLine("Resultados Finales: ");
            Console.WriteLine("Bicicleta: " + bici);
            Console.WriteLine("Motocicleta: " + moto);
            Console.WriteLine("Automovil: " + auto);
            Console.WriteLine("Transporte Publico: " + publico);
        }
    }
}
