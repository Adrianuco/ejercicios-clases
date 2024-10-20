namespace Ejercicio5
{
    internal class Funciones
    {
        public static void InvertirArray(int[] array, int[] invert)
        {
            //Se recorre el arreglo de forma inversa y se almacena en el arreglo invertido
            for (int i = array.Length - 1, j = 0; i >= 0; i--, j++)
            {
                invert[j] = array[i];
            }
        }

        public static int cantidadImpares(int[] array)
        {
            //Se recorre el arreglo y se cuenta la cantidad de números impares
            int count = 0;
            foreach (int i in array)
            {
                //Condicion para evaluar si el número es impar
                if (i % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        public static void ImprimirArray(int[] array)
        {
            //Se recorre el arreglo y se imprime cada elemento
            foreach (int i in array)
            {
                Console.Write(i + "  ");
            }
        }
    }
}