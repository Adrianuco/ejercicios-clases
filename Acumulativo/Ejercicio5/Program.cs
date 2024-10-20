namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---PROGRAMA QUE INVIERTE UN ARREGLO DE ENTEROS---");

            //Se solicita el tamaño del arreglo
            Console.Write("\nIngrese el tamaño del arreglo: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Se crean los arreglos
            int[] array = new int[n];
            int[] invert = new int[n];

            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                //Se solicita un número al usuario
                Console.Write("\nIngrese un número: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();

            //Se invierte el arreglo y se cuenta la cantidad de números impares
            Funciones.InvertirArray(array, invert);
            int impares = Funciones.cantidadImpares(array);

            //Se imprimen los arreglos
            Console.WriteLine("\n---Arreglo Original---");
            Funciones.ImprimirArray(array);
            Console.WriteLine("\n\n---Arreglo Invertido---");
            Funciones.ImprimirArray(invert);
            Console.WriteLine("\n\n\nCantidad de números impares: " + impares);

            Console.ReadKey();
        }
    }
}