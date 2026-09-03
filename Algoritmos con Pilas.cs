namespace Algoritmos_con_Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }




        public bool ExpresionValida(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (pila.Count == 0) return false;
                    char apertura = pila.Pop();

                    if (!EsPareja(apertura, c)) return false;


                }

            }
            return pila.Count == 0;


        }


        public bool EsPareja(char inicio, char cierre)
        {

            return (inicio == '(' && cierre == ')' || inicio == '{' && cierre == '}' || inicio == '[' && cierre == ']');
        }





        //CAPICUA

        public bool EsCapicua(string palabra)
        {
            Stack<char> pila = new Stack<char>();

            int mitad = palabra.Length / 2;

            for (int i = 0; i < mitad; i++)
            {
                pila.Push(palabra[i]);
            }


            int SegundaMitad = (palabra.Length % 2 == 0) ? mitad : mitad + 1;

            for (int i = SegundaMitad; i < palabra.Length; i++)
            {
                char LetraPila = pila.Pop();
                if (LetraPila != palabra[i]) return false;


            }
            return true;




        }


        public static int EvaluarPostFija(string expresion)
        {

            string[] tokens = expresion.Split(' ');

            Stack<int> pila = new Stack<int>();

            foreach (string token in tokens)
            {
                if (token == "+" || token == "*" || token == "-")
                {
                    int operandoDerecho = pila.Pop();
                    int operandoIzquierdo = pila.Pop();
                    int resultado = 0;

                    if (token == "+")
                    {
                        resultado = operandoIzquierdo + operandoDerecho;
                    }
                    else if (token == "-")
                    {
                        resultado = operandoIzquierdo - operandoDerecho;
                    }
                    else if (token == "*")
                    {
                        resultado = operandoIzquierdo * operandoDerecho;
                    }

                    pila.Push(resultado);
                }
                else
                {
                    int num = int.Parse(token);
                    pila.Push(num);


                }



            }
            // Al final del bucle, el único elemento que queda en la pila es el resultado definitivo
            return pila.Pop();




        }


    }
}
