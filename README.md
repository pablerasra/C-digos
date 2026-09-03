# C# Codigos

Repositorio con demostraciones técnicas sobre buenas prácticas, programación orientada a objetos (POO), algoritmos de ordenación y gestión de estructuras de datos en C#.

---

## 📌 1. Comparación y Ordenación Personalizada (IComparable<T>)

Este módulo muestra la implementación de criterios de ordenación jerárquicos y la correcta sobrescritura de métodos base de objetos en C#.

### Conceptos Clave Aplicados
- **IComparable<T>**: Definición de criterios de ordenación primarios (Nivel) y secundarios (Nombre).
- **Igualdad y Hash Code**: Sobrescritura coherente de Equals() y GetHashCode() garantizando la coherencia en colecciones hash.
- **Pattern Matching & Null Safety**: Manejo de nulos y verificación de tipos utilizando patrones modernos de C#.

### Estructura del Código
- `Program.cs`: Incluye la clase de dominio `Jugador` con implementación de la interfaz de comparación y el punto de entrada ejecutable.

---

## 🚀 Cómo ejecutar el proyecto

1. Clona el repositorio:
   git clone https://github.com/pablerasra/C-digos.git

2. Accede al directorio y ejecuta:
   cd C-digos
   dotnet run
