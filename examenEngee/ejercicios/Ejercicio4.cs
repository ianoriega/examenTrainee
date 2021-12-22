using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    public static class Ejercicio4
    {

        public static void EjecutarEjercicio(int datoFilas, int datoColumnas)
        {
            //funcion para detectar un numero primo
            bool EsPrimo(int num)
            {
                int contDivisores = 0;

                for (int i = 1; i <= num; i++)
                {
                    if (num % i == 0)
                        contDivisores++;
                }

                if (contDivisores == 2)
                    return true;
                else
                    return false;
            }

            //funcion para generar el vector de numeros primos hasta el maximo
            Queue<int> GenerarNumerosPrimos(int numMax)
            {
                Queue<int> primos = new Queue<int>();

                for (int i = 1; i <= numMax; i++)
                {
                    if (EsPrimo(i))
                        primos.Enqueue(i);
                }

                return primos;
            }

            Queue<int> primos = GenerarNumerosPrimos(997);


            int[,] matriz = new int[12, 14];

            // agrego numeros primos a la matriz
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    matriz[i, j] = primos.Dequeue();
                }
            }

            //impresion de la matriz
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 14; j++)
                {
                    Console.Write("{0,4} ", matriz[i, j]);
                }
                Console.WriteLine("\n");
            }

            //funcion para extraer la matriz a partir de la principal
            int[,] extraerMatriz(int filas, int columnas)
            {
                int[,] auxMatriz = new int[filas, columnas];

                for (int i = 0; i < filas; i++)
                {
                    for (int j = 0; j < columnas; j++)
                    {
                        auxMatriz[i, j] = matriz[i, j];
                    }
                }

                return auxMatriz;
            }


            int[,] matrizPeque = extraerMatriz(datoFilas, datoColumnas);

            Console.WriteLine("\nMatriz extraida\n");

            //impresion de la matriz pequeña
            for (int i = 0; i < matrizPeque.GetLength(0); i++)
            {
                for (int j = 0; j < matrizPeque.GetLength(1); j++)
                {
                    Console.Write("{0,4} ", matrizPeque[i, j]);
                }
                Console.WriteLine("\n");
            }

            //funcion para extraer la lista ordenada a partir de la matriz pequeña
            List<int> extraerSalida(int[,] matriz)
            {
                List<int> arrAux = new List<int>();
                int fila = 0;
                int columna = 0;
                int contadorIteraciones = 0;
                int i = 0;
                int cantColumnas = matriz.GetLength(1);
                int cantFilas = matriz.GetLength(0);
                int cantColumnasIzq = 0;
                int cantFilasAbajo = 0;

                while (contadorIteraciones <= matriz.GetLength(0))
                {
                    columna = contadorIteraciones;
                    fila = contadorIteraciones;

                    for (i = columna; i < cantColumnas; i++)
                    {
                        arrAux.Add(matriz[fila, i]);
                    }
                    columna = i - 1;
                    fila++;


                    for (i = fila; i < cantFilas; i++)
                    {
                        arrAux.Add(matriz[i, columna]);
                    }

                    fila = i - 1;

                    for (i = columna - 1; i >= cantColumnasIzq; i--)
                    {
                        arrAux.Add(matriz[fila, i]);
                    }

                    columna = i + 1;

                    for (i = fila - 1; i > cantFilasAbajo; i--)
                    {
                        arrAux.Add(matriz[i, columna]);
                    }
                    fila = i + 1;


                    cantColumnas--;
                    cantFilas--;
                    cantColumnasIzq++;
                    cantFilasAbajo++;
                    contadorIteraciones++;
                }

                if (matriz.GetLength(0) < matriz.GetLength(1))
                {
                    arrAux.RemoveAt(arrAux.Count() - 1);
                }


                return arrAux;
            }

            List<int> aux = extraerSalida(matrizPeque);

            //impresion del vector ordenado
            foreach (var item in aux)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}
