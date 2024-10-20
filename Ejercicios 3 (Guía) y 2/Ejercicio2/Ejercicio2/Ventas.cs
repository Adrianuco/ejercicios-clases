using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Ventas
    {
        //Se declara un "arreglo" donde se guardaran las ventas y una variable de los días que se registraran
        private double[] ventas;
        private int díasv;

        public Ventas(int dias)
        {
            //La variable "ventas" dependera de los días que se desean registrar
            ventas = new double[dias];
            //La variable "díasv" dependera de lo ingresado en el "Main"
            díasv = dias;
        }

        public void AgregarVentas()
        {
            //Usamos un bucle "for" para ir registrando cada día ingresado por el usuario
            for (int i = 0; i < díasv; i++)
            {
                //Usando la variable "i", se crea un contador indicado el día
                Console.WriteLine("");
                Console.WriteLine("Día No.{0}", i + 1);
                Console.Write("Ingrese la venta del día: ");
                ventas[i] = double.Parse(Console.ReadLine());
                
                //Usando un "if", se observa que la venta ingresada es correcta
                //Si no lo es, se le informara al usada, se eliminara del arreglo y se reinicia el contador
                if (ventas[i] < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Valor Incorrecto de Venta, Intete Otra Vez...");
                    i--;
                }
            }
        }

        public double TotalVendido()
        {
            //Se declara una variable para el total de ventas y es iniciada en 0
            double totalventas = 0;
            //Con un bucle "foreach" se recorre todas las ventas ingresadas
            foreach (var venta in ventas)
            {
                //Conforme pasa cada recorrido se van sumando todas las ventas en la variable del total de ventas
                totalventas += venta;
            }
            //Se regresa la variable del total de ventas en el "Main"
            return totalventas;
        }

        public int DíaVentaMasAlta()
        {
            //Se declara la variable para el día máximo y la venta máxima la cual comienza desde la primera venta registrada
            double ventamax = ventas[0];
            int díamax = 0;

            //Mediante un bucle "for" se recorre todas las ventas registradas por el usuario
            //"i" comienza desde 1 por el contador de la primera función
            for (int i = 1; i < díasv; i++)
            {
                //Mediante un "if" se verifica si alguna de las ventas es la mayor
                if (ventas[i] > ventamax)
                {
                    //Gracias al "for", constantemente se actualizan las dos variables declaradas
                    //Se actualiza la venta máxima conforme pasa el ciclo hasta que se de la que es la mayor
                    ventamax = ventas[i];
                    //También se registra el día donde esta dicha venta mediante la variable "i"
                    díamax = i;
                }
            }
            //Se regresa la del día máximo en el "Main" y se suma 1 para pasar del día 0 a 1
            return díamax + 1;
        }
    }
}
