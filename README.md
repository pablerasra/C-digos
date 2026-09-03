# C# Codigos

Repositorio con demostraciones técnicas sobre buenas prácticas, programación orientada a objetos (POO), algoritmos de ordenación y gestión de estructuras de datos en C#.

---

##1. Comparación y Ordenación Personalizada (IComparable<T>)

Este módulo muestra la implementación de criterios de ordenación jerárquicos y la correcta sobrescritura de métodos base de objetos en C#.

### Conceptos Clave Aplicados
- **IComparable<T>**: Definición de criterios de ordenación primarios (Nivel) y secundarios (Nombre).
- **Igualdad y Hash Code**: Sobrescritura coherente de Equals() y GetHashCode() garantizando la coherencia en colecciones hash.
- **Pattern Matching & Null Safety**: Manejo de nulos y verificación de tipos utilizando patrones modernos de C#.

### Estructura del Código
- `Comparacion_y_Ordenacion_Personalizada.cs`: Incluye la clase de dominio `Jugador` con implementación de la interfaz de comparación y el punto de entrada ejecutable.


---

##2. Colección Genérica e Iteración (`IEnumerable` & `yield`)

Creación de una clase de colección personalizada genérica que demuestra el redimensionamiento manual de arrays y la iteración diferida.

### Conceptos Clave Aplicados
- **Generics (`<T>`)**: Creación de la clase `MyCollection<T>` para manejar datos de forma flexible e independiente del tipo.
- **Redimensionamiento Manual de Arrays**: Copia explícita de elementos mediante bucles `for` para incrementar dinámicamente la capacidad del array interno.
- **Evaluación Diferida con `yield return`**: Uso del iterador `yield` dentro del método `ObtenerPrimeros` para devolver elementos bajo demanda sin instanciar listas adicionales.
- **Implementación de `IEnumerable`**: Definición de `GetEnumerator` genérico y no genérico para habilitar el recorrido con sintaxis `foreach`.

### Estructura del Código
- `Coleccion_Generica_Iteradores.cs`: Contiene la clase `MyCollection<T>` y el método `Main` para la ejecución del flujo de prueba.

---


##3. Estructura de Datos Cola Basada en Nodos (`NodeQueue<T>`)

Implementación personalizada de una estructura de datos FIFO (First-In, First-Out) utilizando referencias dinámicas de nodos enlazados en memoria.

### Conceptos Clave Aplicados
- **Estructuras Enlazadas Directas**: Gestión manual de nodos mediante punteros implícitos (`Next`), controlando cabeza (`_top`) y cola (`_bottom`).
- **Operaciones FIFO Tradicionales**: Métodos `Enqueue`, `Dequeue` y `Peek` con manejo de estados y excepciones.
- **Búsqueda y Eliminación Personalizada**: Implementación del método `EliminarProhibido` para desenlazar nodos de forma condicional ajustando referencias internas según su posición (inicio, medio o fin).
- **`EqualityComparer<T>.Default`**: Comparación genérica segura de elementos dinámicos sin restricciones de tipo.

### Estructura del Código
- `Cola_Nodos_FIFO.cs`: Contiene la clase genérica `NodeQueue<T>`, la clase anidada `Node` y el punto de entrada ejecutable.
##Cómo ejecutar el proyecto

1. Clona el repositorio:
   git clone https://github.com/pablerasra/C-digos.git

2. Accede al directorio y ejecuta:
   cd C-digos
   dotnet run
