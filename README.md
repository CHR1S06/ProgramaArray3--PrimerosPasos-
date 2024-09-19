# ProgramaArray3--PrimerosPasos-

## Descripción del Problema

El objetivo del programa es desarrollar una aplicación que permita al usuario ingresar una cantidad indefinida de números enteros, almacenarlos en una estructura de datos lineal y realizar dos validaciones importantes sobre los datos ingresados.

## Requisitos del Programa

### Solicitar Entrada del Usuario

- El programa debe pedir al usuario que introduzca una cantidad específica de números enteros.
- Esta cantidad debe ser determinada por el usuario al inicio del programa.

### Almacenamiento de Datos

- Los números ingresados deben ser almacenados en una estructura de datos lineal. En C#, una opción común para esto es un arreglo (`array`).

### Determinación del Menor Valor

- Una vez que todos los números han sido ingresados y almacenados, el programa debe calcular el menor valor en el arreglo y mostrarlo al usuario.

### Verificación de Valores Repetidos

- El programa también debe verificar si alguno de los números ingresados se repite al menos una vez.
- Debe informar al usuario si hay valores repetidos y, en caso afirmativo, indicar que existe al menos un valor duplicado.

## Abordaje del Problema

Para abordar este problema, se desarrolló una aplicación en C# que implementa las siguientes funcionalidades:

### Definición de la Estructura de Datos

- Se utiliza un arreglo de enteros (`int[]`) para almacenar los números proporcionados por el usuario. Este arreglo se inicializa dinámicamente en función de la cantidad de elementos que el usuario desea ingresar.

### Método para Solicitar y Almacenar Datos

- El programa contiene un método para solicitar la cantidad de números y luego ingresar cada uno de ellos en el arreglo. Este método se asegura de que los datos ingresados sean válidos y maneja posibles errores de entrada.

### Cálculo del Menor Valor

- Utilizando LINQ, el programa encuentra el valor mínimo dentro del arreglo. Esta operación se realiza de manera eficiente y el resultado se muestra al usuario.

### Verificación de Repeticiones

- El programa emplea un enfoque para contar la frecuencia de cada número en el arreglo. Se utiliza un diccionario (`Dictionary<int, int>`) para almacenar las ocurrencias de cada número y determinar si algún valor se repite.

## Implementación

La implementación del programa consta de varias clases:

### Clase `ArrayEstrc`

- **Función**: Solicita al usuario los números y los almacena en un arreglo.
- **Métodos**: `structureArray()` para la entrada de datos.

### Clase `ValorMenor`

- **Función**: Calcula el menor valor en el arreglo.
- **Métodos**: `ValidacionMenorValor()` que invoca al método `structureArray()` y calcula el valor mínimo usando LINQ.

### Clase `ValorRepetido`

- **Función**: Verifica si hay valores repetidos en el arreglo.
- **Métodos**: `ValidacionVR()` que toma el arreglo como parámetro y determina si hay valores duplicados utilizando un diccionario para contar las ocurrencias.

### Clase `Program`

- **Función**: Coordina la ejecución de las validaciones.
- **Métodos**: `Main()` para ejecutar las validaciones y manejar la interacción con el usuario.

## Ejecución del Programa

El usuario inicia el programa, introduce la cantidad de números y luego ingresa cada valor uno por uno. Después de completar la entrada de datos, el programa muestra el menor valor y verifica si hay valores repetidos, proporcionando un informe claro al usuario sobre los resultados.

## Conclusión

Este programa demuestra cómo manejar arreglos de enteros en C#, realizar cálculos básicos como encontrar el valor mínimo, y aplicar técnicas de validación para detectar valores repetidos. La implementación modular permite una fácil extensión y mantenimiento del código, facilitando futuras mejoras o ajustes según los requisitos.
