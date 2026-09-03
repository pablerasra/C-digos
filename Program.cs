namespace Colección Genérica e Iteración Personalizada

{

    using System.Collections;

    using System.Collections.Generic;

    internal class Program

    {

        static void Main(string[] args)

        {

            int[] arrayColeccion = new int[] { 1, 4, 6, 7, 8 };



            MyCollection<int> coleccion = new MyCollection<int>(arrayColeccion);



            coleccion.Mostrar();



            coleccion.Agregar(10);



            coleccion.Mostrar();



            var primeros = coleccion.ObtenerPrimeros(3);



            foreach (int primero in primeros)

            {

                Console.WriteLine(primero);

            }







        }

    }





    public class MyCollection<T> : IEnumerable

    {





        public T[] Array { get; set; }

        public int Contador { get; set; }



        public MyCollection(T[] array)

        {



            Contador = array.Length;

            Array = array;



        }



        public void Agregar(T item)

        {

            T[] nuevoArray = new T[Array.Length + 1];



            for (int i = 0; i < Array.Length; i++)

            {



                nuevoArray[i] = Array[i];

            }



            //añadimos el ultimo elemento



            nuevoArray[nuevoArray.Length - 1] = item;



            Array = nuevoArray;



            Contador++;







        }



        public void Mostrar()

        {



            foreach (T elemento in Array)

            {

                Console.WriteLine(elemento);

            }

        }



        public IEnumerable<T> ObtenerPrimeros(int cantidad)
        {



            for (int i = 0; i < cantidad; i++)

            {

                yield return Array[i];





            }



        }

        public IEnumerator<T> GetEnumerator()

        {

            for (int i = 0; i < Contador; i++)

            {

                yield return Array[i];

            }

        }

        // 2. Este método es necesario por compatibilidad (es parte de la interfaz base IEnumerable)

        IEnumerator IEnumerable.GetEnumerator()

        {

            return GetEnumerator();

        }

    }

}


