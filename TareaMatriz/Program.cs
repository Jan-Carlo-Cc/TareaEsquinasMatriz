using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TareaMatriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tarea Crea un programa que recorra una matriz y sume las esquinaz de esta.

            Console.WriteLine("Ingrese en tamaño de la matriz que desee generar");

            int tamaño = int.Parse(Console.ReadLine());
            Console.WriteLine(tamaño);

            int fila = tamaño;
            int columna = tamaño;
            int[,] matriz = new int[fila, columna];
            int contador = 0;

            int sumaEsquinas = 0;
            int top_left = 0;
            int top_right = 0;
            int bot_left = 0;
            int bot_right = 0;


            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    matriz[f, c] = ++contador;
                    Console.Write("[ " + matriz[f, c] + " ]");

                    if (f == 0 && c == 0)
                    {
                        top_left = matriz[f, c];
                    }
                    if (f == 0 && c == matriz.GetLength(0)-1)
                    {
                        top_right= matriz[f, c];
                    }
                    if (f == matriz.GetLength(1)-1 && c == 0)
                    {
                        bot_left = matriz[f, c];
                    }
                    if (f == matriz.GetLength(0)-1 && c == matriz.GetLength(0) - 1)
                    {
                        bot_right = matriz[f, c];
                    }

                }
                Console.WriteLine();
            }
            sumaEsquinas = top_left + top_right + bot_left + bot_right;
            Console.WriteLine("La Suma de las Esquinaz es : " + sumaEsquinas);

        }
    }
}
