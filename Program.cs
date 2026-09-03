namespace Comparación_y_Ordenación_personalizada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Jugador[] jugadores =
            {
                new Jugador(2, "pablo"),
                new Jugador(1, "raul"),
                new Jugador(0, "alvaro"),
                new Jugador(1, "aloe")
            };

            Console.WriteLine("Lista sin ordenar");
            ImprimirJugadores(jugadores);

            // Ordena usando IComparable<Jugador>
            Array.Sort(jugadores);

            Console.WriteLine("\nLista ordenada (Nivel ASC, Nombre ASC)");
            ImprimirJugadores(jugadores);
        }

        private static void ImprimirJugadores(IEnumerable<Jugador> jugadores)
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador);
            }
        }
    }

    public class Jugador : IComparable<Jugador>
    {
        public int Nivel { get; set; }
        public string Nombre { get; set; }

        public Jugador(int nivel, string nombre)
        {
            Nivel = nivel;
            Nombre = nombre ?? string.Empty;
        }

        public int CompareTo(Jugador? other)
        {
            if (other is null) return 1;

            // 1. Criterio primario: Nivel
            int resultadoNivel = Nivel.CompareTo(other.Nivel);
            if (resultadoNivel != 0)
            {
                return resultadoNivel;
            }

            // 2. Criterio secundario: Nombre (alfabético)
            return string.Compare(Nombre, other.Nombre, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj)
        {
            if (obj is Jugador other)
            {
                return Nivel == other.Nivel &&
                       string.Equals(Nombre, other.Nombre, StringComparison.OrdinalIgnoreCase);
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Se combinan las propiedades que definen la igualdad del objeto
            return HashCode.Combine(Nivel, Nombre?.ToLowerInvariant());
        }

        public override string ToString()
        {
            return $"Jugador: {Nombre} | Nivel: {Nivel}";
        }
    }
}
