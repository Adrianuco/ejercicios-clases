namespace Ejercicio4
{
    internal class Class
    {
        //Calcular el Factorial
        public static int Factorial(int n)
        {
            //Se crea una variable para almacenar el resultado
            //Se inicializa en 1 para que no afecte la multiplicación
            int fact = 1;

            //Se crea un bucle for que se ejecutará n veces
            //Se multiplica el valor de fact por el valor de i
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
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