namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----PROGRAMA QUE CALCULA EL FACTORIAL DE UN ARREGLO DE ENTEROS----");

            //Se solicita el tamaño del arreglo
            Console.WriteLine("\nIngrese el tamaño del arreglo: ");
            int n = Convert.ToInt32(Console.ReadLine());
            //Se crean los arreglos
            int[] array = new int[n];
            int[] factArray = new int[n];

            Console.Clear();
            for (int i = 0; i < n; i++)
            {
                //Se crea un bucle do-while en caso de que el usuario ingrese un número negativo
                do
                {
                    //Se solicita un número al usuario
                    Console.Write("\nIngrese un número: ");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    //Se verifica que el número sea positivo
                    if (array[i] <= 0)
                    {
                        Console.WriteLine("Error. Ingrese un número positivo.");
                    }
                    else
                    {
                        factArray[i] = Class.Factorial(array[i]);
                        break;
                    }
                }while(true);
            }
            Console.Clear();
            //Se imprimen los arreglos
            Console.WriteLine("----Arreglo original----");
            Class.ImprimirArray(array);

            Console.WriteLine("\n\n----Arreglo de factoriales----");
            Class.ImprimirArray(factArray);
            Console.ReadKey();
        }
    }
}