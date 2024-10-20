using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ejercicio3Guía.Funciones;

namespace Ejercicio3Guía
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ° Nombres: Juan Castellón, Adriano Almanza
            ° Docente: Silvia Gigdalia Ticay Lopez
            ° Fecha: 18 de octubre del año 2024
            ° Ejercicio 3 - Guía Didactica
            */

            //Creamos un objeto que nos permitira usar los procesos de la clase "Funciones" dentro del "Main"
            Funciones funciones = new Funciones();

            //Creamos una lista la cual almacenara el nombre de los estudiantes
            List<string> estudiantes = new List<string>();
            //Creamos otra lista la cual almacenara las calificaciones de cada estudiante
            List<List<double>> calificaciones = new List<List<double>>();

            //Declaramos las variables que ingresara el usuario en el "Main"
            string nombre;
            int numestudiantes, numcalificaciones;

            Console.WriteLine("Bienvenido al sistema de gestión de calificaciones");

            //Con un bucle "do-while" para verificar que el usuario ingrese un valor lógico para la cantidad de estudiantes
            do
            {
                Console.WriteLine("");
                Console.Write("¿Cuántos estudiantes desea registrar? ");
                numestudiantes = int.Parse(Console.ReadLine());

                //Mediante un "if" se le informa al usuario del error, y lo manda de regreso a ingresar un valor correcto
                if (numestudiantes < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Valor Incorrecto de Estudiantes, Intente Otra Vez...");
                }
            }
            while (numestudiantes < 0);
            
            //Una vez tenga el valor correcto, mediante un ciclo "for" se va ingresando los datos del estudiante
            for (int i = 0; i < numestudiantes; i++)
            {
                Console.WriteLine("");
                Console.Write("Ingrese el nombre del Estudiante No.{0}: ", i + 1);
                nombre = Console.ReadLine();

                //Creamos una lista la cual almacenara las notas de los estudiantes de los distintos cortes
                List<double> notas = new List<double>();
                //Creamos también una variable que almacenara cada nota para después pasarla a la lista
                double nota;

                //Igualmente, mediante "do-while" verificamos que la cantidad de notas a ingresar sea un valor lógico
                do
                {
                    Console.WriteLine("");
                    Console.Write("¿Cuántas calificaciones desea ingresar para {0}? ", nombre);
                    numcalificaciones = int.Parse(Console.ReadLine());

                    //Mediante un "if" informamos al usuario del error, y es regresado a la cantidad de notas
                    if (numcalificaciones < 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Valor Incorrecto de Calificaciones, Intente Otra Vez...");
                    }
                }
                while (numcalificaciones < 0);
                
                //Nuevamente con un "for" se va ingresado las calificaciones del estudiante
                for (int j = 0; j < numcalificaciones; j++)
                {
                    Console.WriteLine("");
                    Console.Write("Ingrese la calificación del {0} Corte: ", j + 1);
                    nota = double.Parse(Console.ReadLine());

                    //Mediante un "if" se verifica que la nota sea lógica, no un valor negativo
                    if (nota > 0)
                    {
                        //Se registra la nota ingresada en la lista de notas en caso que si sea correcto
                        notas.Add(nota);
                    }
                    //En caso que no sea, se reinicia el contador del bucle y se debe ingresar la nota otra vez
                    else
                    {
                        //Le informamos al usuario que es incorrecta la nota y reiniciamios el contador
                        Console.WriteLine("");
                        Console.WriteLine("Valor Incorrecto de Nota, Intente Otra Vez...");
                        j--;
                    }
                }
                
                //LLamamos a la función "AgregarEstudiante" de la clase "Funciones" y registra todo los datos ingresados a la clase
                funciones.AgregarEstudiante(estudiantes, calificaciones, nombre, notas);
            }

            //Llamamos a la función "DeterminarAltoBajoEstudiante" de la clase para que se realize dicho proceso y sea entregado en el "Main"
            funciones.DeterminarAltoBajoEstudiante(estudiantes, calificaciones);

            Console.ReadKey();
        }
    }
}
