namespace Pila_y_Cola_Enlazadas
{
        using System;

        using System.Collections.Generic;

            internal class Program

            {

                static void Main(string[] args)

                {

                    // 1. Probamos la PILA (LIFO)

                    PilaEnlazada<string> inventario = new PilaEnlazada<string>();

                    inventario.Push("Espada");

                    inventario.Push("Escudo");

                    inventario.Push("Poción");



                    Console.WriteLine("--- PILA (LIFO: Sale la Poción primero) ---");

                    while (!inventario.EstaVacia())

                    {

                        Console.WriteLine("Usando: " + inventario.Pop());

                    }
                    // 2. Probamos la COLA (FIFO)

                    ColaEnlazada<string> fila = new ColaEnlazada<string>();

                    fila.Enqueue("Jugador 1");

                    fila.Enqueue("Jugador 2");

                    fila.Enqueue("Jugador 3");



                    Console.WriteLine("\n--- COLA (FIFO: Sale el Jugador 1 primero) ---");

                    while (!fila.EstaVacia())

                    {

                        Console.WriteLine("Atendiendo a: " + fila.Dequeue());

                    }
                }
            }



            // El nodo es el mismo para ambas estructuras

            public class Nodo<T>

            {

                public T Dato { get; set; }

                public Nodo<T> Siguiente { get; set; }



                public Nodo(T dato)

                {

                    Dato = dato;

                    Siguiente = null;

                }

            }
            // ESTRUCTURA PILA (Un solo puntero: tope)

            public class PilaEnlazada<T>

            {

                private Nodo<T> tope;



                public void Push(T dato)

                {

                    Nodo<T> nuevo = new Nodo<T>(dato);

                    nuevo.Siguiente = tope;

                    tope = nuevo;

                }
                public T Pop()

                {

                    if (tope == null) throw new Exception("La pila está vacía");

                    T dato = tope.Dato;

                    tope = tope.Siguiente;

                    return dato;

                }
                public bool EstaVacia() => tope == null;

            }



            // ESTRUCTURA COLA (Dos punteros: frente y final)

            public class ColaEnlazada<T>

            {

                private Nodo<T> frente;

                private Nodo<T> final;



                public void Enqueue(T dato)//añada un dato a la cola

                {

                    Nodo<T> nuevo = new Nodo<T>(dato);//creamos el dato a añadir

                    if (final == null)

                    {

                        frente = nuevo;

                        final = nuevo;

                    }

                    else

                    {

                        final.Siguiente = nuevo;

                        final = nuevo;

                    }

                }



                public T Dequeue()//elimina un dato de la cola

                {

                    if (frente == null) throw new Exception("La cola está vacía");

                    T dato = frente.Dato;

                    frente = frente.Siguiente;

                    if (frente == null) final = null;

                    return dato;

                }



                public bool EstaVacia() => frente == null;

            }

        }

    



