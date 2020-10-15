using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBasico11
{
    class EjercicioBasico11
    {
        static void PrintCategoriasJugadores(String[] categorias)
        {
            for(Int32 i = 0; i < categorias.Length; i++)
            {
                Console.WriteLine("Jugador " + i + " pertnece a la categoria " + categorias.GetValue(i) + ".");
            }
        }
        static void Main(string[] args)
        {
            String[] categorias = new String[5];
            Int32 i = 0;
            Console.WriteLine("Introduzca la edad de los 5 jugadores para identificar su categoria.(La edad debe estar comprendida entre 14 años y 99");
            do
            {
                Console.Write("Edad del jugador " + (i + 1) + ": ");
                try
                {
                    Int32 edad = Convert.ToInt32(Console.ReadLine());
                    if (edad > 13 && edad < 100)
                    {
                        if (edad < 16)
                        {
                            categorias[i] = "cadete";
                        }
                        else if (edad < 18)
                        {
                            categorias[i] = "juvenil";
                        }
                        else
                        {
                            categorias[i] = "senior";
                        }
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("La edad no es admitida.");
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (i < 5);
            PrintCategoriasJugadores(categorias);
        }
    }
}
