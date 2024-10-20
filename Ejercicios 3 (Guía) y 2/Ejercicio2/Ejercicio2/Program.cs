using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ° Nombre: Juan Castellón, Adriano Almanza
            ° Docente: Silvia Gigdalia Ticay Lopez
            ° Fecha: 18 de octubre del año 2024
            ° Ejercicio 2 - Evaluación II Corte - Ventas
            */

            //Declaramos tres variables, los días a registrar, el día con más ventas, y el total de ventas
            int días, maxdía;
            double totalventa;

            Console.WriteLine("Bienvenido al registro de ventas diaras");
            //Usando un bucle "do-while" se verifica que los días ingresado sean de un valor correcto
            do
            {
                Console.WriteLine("");
                Console.Write("Cuantos días desea registrar? ");
                días = int.Parse(Console.ReadLine());

                //Mediante un "if" se verifica los días
                //Si no son un valor correcto, se le informa al usuario y se reincia la solicitud de días
                if (días < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Valor Incorrecto de Días, Intete Otra Vez...");
                }
            }
            while (días < 0);

            //Se llama a la clase "Ventas" y se crea una variable de las ventas diarias para ser usada en el "Main"
            //Se manda la variable de los "días" a registrar a la clase de "Ventas"
            Ventas ventasdiarias = new Ventas(días);

            //Se llama a la función de agregar las ventas
            ventasdiarias.AgregarVentas();

            //Se llama a la función del total que se vendio
            //Con el resultado de la función, se guardara en la variable "totalventa" para ser usada en el "Main"
            totalventa = ventasdiarias.TotalVendido();

            //Se llama la función de día con la venta más alta
            //Con el resultado de la función, se guardara en la variable "maxdía" para ser usada en el "Main"
            maxdía = ventasdiarias.DíaVentaMasAlta();

            //Se muestra el total de ventas con la variable de "días" y el "totalventa"
            Console.WriteLine("");
            Console.WriteLine("Total Vendido");
            Console.WriteLine("El total de ventas en {0} días fue de: {1}", días, totalventa);

            //Se muestra el día con más ventas mediante la variable de "maxdía"
            Console.WriteLine("");
            Console.WriteLine("Día con más Ventas");
            Console.WriteLine("El Día con más Ventas fue el Día No.{0}", maxdía);

            Console.ReadKey();
        }
    }
}
