# ProgramaArray1--PrimerosPasos-

Descripción del Problema:

Se requiere diseñar un programa en C# que maneje una matriz bidimensional de enteros de tamaño 10x2. El programa debe realizar las siguientes tareas:

Creación y Inicialización de la Matriz:

Crear una matriz de enteros con 10 filas y 2 columnas.

Inicializar cada elemento de la matriz con un valor basado en su índice lineal multiplicado por 5. El índice lineal se calcula a partir de las coordenadas de la matriz.


-Impresión de la Matriz:

Mostrar los valores de la matriz en la consola en un formato de tabla, organizada en 10 filas y 2 columnas.


-Solución Proporcionada:

El programa se divide en dos partes principales:

Clase Array1: Contiene la lógica para inicializar y mostrar la matriz.

Método ArrayProgram(): Crea una matriz de tamaño 10x2 y llena cada elemento con un valor calculado. Luego llama al método ImprimirMatriz para mostrar la matriz en la consola.

Método ImprimirMatriz(int[,] array): Imprime los elementos de la matriz en la consola, organizados en un formato de tabla.

Clase Program: Contiene el método Main que sirve como punto de entrada del programa.

Método Main(string[] args): Llama al método ArrayProgram() de la clase Array1 para ejecutar la funcionalidad descrita.
