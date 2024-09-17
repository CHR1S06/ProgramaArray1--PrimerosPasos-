using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaArray1.Array_Program
{
    public class Array1
    {
        public static void ArrayProgram()
        {
            const int elementosArray = 20; //Constante de la cantidad de elementos en el array
            int[] array = new int [elementosArray]; //Creacion del arreglo 

            Console.WriteLine("            " + "{0}" + "{1,7}", "Columna", ""); //encabezados
            Console.WriteLine("Filas");
            //Imprime el valor de cada elemento de la matriz
            for (int contador = 0; contador < array.Length; contador++)
            {
                array[contador] += contador*5; //Multiplica el indice del elemento por 5 y lo adquiere como valor 
                Console.WriteLine("{0,16}" + "{1,8}", contador, array[contador]);
            }
        }
    }
}
