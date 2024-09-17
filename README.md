# ProgramaArray1--PrimerosPasos-

//Objetivo del Programa:

El objetivo es desarrollar un programa en C# que maneje una matriz de enteros y realice las siguientes tareas:

-Creación e Inicialización de la Matriz:

El programa debe crear una matriz unidimensional de 20 elementos de tipo entero.

Cada elemento de la matriz debe ser inicializado con un valor que se calcula multiplicando el índice del elemento por 5. Por ejemplo, el elemento en la posición 0 debe tener el valor 0*5, el elemento en la posición 1 debe tener el valor 1*5, y así sucesivamente 

hasta el elemento en la posición 19, que debe tener el valor 19*5.

-Impresión de los Elementos:

El programa debe imprimir en la consola cada índice de la matriz junto con su valor correspondiente. La salida debe mostrar claramente el índice y el valor asociado a cada posición de la matriz.

-Explicación del Problema:

-Creación del Array:
Se requiere crear un array de enteros con una longitud fija de 20 elementos.

Este array se llenará con valores calculados a partir de sus índices, donde cada valor es el resultado de multiplicar el índice por 5. Esto implica que el valor en el índice 0 será 0, en el índice 1 será 5, en el índice 2 será 10, y así sucesivamente hasta el índice 19, cuyo valor será 95.

-Impresión de Valores:

Después de llenar el array con los valores calculados, el siguiente paso es imprimir en la consola los índices del array junto con sus respectivos valores. La impresión debe estar bien formateada para facilitar la lectura y comprensión de los datos.

//Descripción del Programa Creado:

El programa desarrollado aborda este problema mediante la implementación de dos clases:

-Clase Array1:

Contiene el método estático ArrayProgram, que realiza las siguientes acciones:

Define una constante para el tamaño del array (elementosArray).

Crea el array de enteros con el tamaño especificado.

Llena el array con valores calculados como el índice multiplicado por 5.

Imprime los índices y los valores del array en la consola, mostrando cada índice con su valor correspondiente en una tabla formateada.

-Clase Program:

Contiene el método Main, que actúa como el punto de entrada del programa.

Llama al método ArrayProgram de la clase Array1 para ejecutar el proceso de creación e impresión del array.
