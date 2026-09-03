namespace Colas_y_Nodos
{
    
        internal class Program
        {
            static void Main(string[] args)
            {
                NodeQueue<string> cola = new NodeQueue<string>();

                cola.Enqueue("Fuego");
                cola.Enqueue("Hielo");
                cola.Enqueue("Tierra");

                cola.RecorrerCola();
                cola.EliminarProhibido("Hielo");
                cola.RecorrerCola();


            }
        }

        public class NodeQueue<T>
        {

            public class Node
            {
                public T Value { get; set; }

                public Node Next { get; set; }

                public Node(T value) { Value = value; }


            }

            private Node _top;
            private Node _bottom;
            private int _count;

            public int Count => _count;
            public bool IsEmpty() => _count == 0;




            //métodos principales:

            public void Enqueue(T element)
            {
                Node nuevoNodo = new Node(element);

                if (IsEmpty())
                {
                    _top = nuevoNodo;
                    _bottom = nuevoNodo;
                }
                else
                {

                    _bottom.Next = nuevoNodo;
                    _bottom = nuevoNodo;
                }

                _count++;
            }


            public T Dequeue()
            {
                if (IsEmpty()) throw new Exception("La cola esta vacía");

                T Value = _top.Value;
                _top = _top.Next;



                _count--;

                if (_count == 0) _bottom = null;

                return Value;
            }


            public T Peek()
            {
                if (IsEmpty()) throw new Exception("La cola esta vacia");
                return _top.Value;

            }

            public void RecorrerCola()
            {

                Node actual = _top;

                while (actual != null)
                {

                    Console.WriteLine(actual.Value);
                    actual = actual.Next;
                }

            }


            public void EliminarProhibido(T prohibido)
            {
                if (IsEmpty()) return;

                Node actual = _top;
                Node anterior = null;

                while (actual != null)
                {
                    if (EqualityComparer<T>.Default.Equals(actual.Value, prohibido))
                    {
                        //En caso de que sea el primero:
                        if (actual == _top)
                        {
                            _top = _top.Next;
                            if (_top == null) _bottom = null;


                        }

                        //En caso de ser el ultimo

                        if (actual == _bottom)
                        {
                            anterior.Next = null;
                            _bottom = anterior;

                        }

                        //En caso de estar en el medio

                        else
                        {
                            anterior.Next = actual.Next;

                        }
                        _count--;

                    }
                    else
                    {
                        anterior = actual;//solo avanza el anterior si no eliminamos nada
                    }
                    actual = actual.Next;


                }
            }
        }
}
