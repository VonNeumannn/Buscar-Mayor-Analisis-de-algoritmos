using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tarea_1
{
    internal class Program
    {
        static int mayorArreglo(int[] arreglo)
        {
            int maximo = arreglo[0];                //1
            int tamaño = arreglo.Length;            //1+n
            for (int i = 0; i < tamaño; i++)        //2n+2
            {
                //Console.WriteLine(arreglo[i]);      
                if (arreglo[i] > maximo)            //n+1
                    maximo = arreglo[i];            //+1
            }
            return maximo;                          //+1
        }                                           //1+1+1+1+n+2n+2+n+1 = 4n+7

        static int[] crearArreglo(int[] arreglo)
        {
            int tamaño = arreglo.Length;
            Random aleatorio = new Random();

            for (int i = 0; i < tamaño; i++)
            {
                int nRandom = aleatorio.Next(0, 10000);
                arreglo[i] = nRandom;
            }
            return arreglo;
        }
        static void Main(string[] args)
        {
            int[] arreglo = new int[500];
            crearArreglo(arreglo);

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int x = mayorArreglo(arreglo);

            stopWatch.Stop();
            Console.WriteLine("Tiempo: "+stopWatch.Elapsed.Duration());
            Console.WriteLine("El máximo es: "+x);
            
        }
    }
}
