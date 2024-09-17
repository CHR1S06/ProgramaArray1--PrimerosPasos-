using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaArray1.Array_Program
{
    public class Array1
    {
        public static void ArrayProgram()
        {
            int[,] array = new int [10,2]; //Creacion de la matriz 2x2 de 20 elementos

            //Inicializa la matriz con valores basados en el índice lineal multiplicado por 5
            for (int fila = 0; fila < 10; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    // Calcular el índice lineal del elemento
                    int indiceLineal = fila * 2 + columna;
                    array[fila, columna] = indiceLineal * 5;
                }
            }

            // Imprimir la matriz
            ImprimirMatriz(array);
        }

        //Metodo para imprimir la matriz
        static void ImprimirMatriz(int[,] array)
        {
            int filas = array.GetLength(0); // Número de filas
            int columnas = array.GetLength(1); // Número de columnas

            Console.WriteLine("Matriz 10x2:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    // Imprimir el elemento en la fila i y columna j
                    Console.Write($"{array[i, j],4}"); // Alineación de salida
                }
                Console.WriteLine(); // Nueva línea al final de cada fila
            }
        }
    }
}
