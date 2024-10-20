using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Guía
{
    internal class Funciones
    {
        //Creamos una función para agregar los estudiantes la cual recibira los mismos datos del "Main" con sus tipos
        public void AgregarEstudiante(List<string> estudiantes, List<List<double>> calificaciones, string nombre, List<double> notas)
        {
            //Agrega el nombre del estudiante del "Main" a la lista de estudiantes de la clase "Funciones"
            estudiantes.Add(nombre);
            //Agrega las notas del estudiante del "Main" a la lista de calificaciones de la clase "Funciones"
            calificaciones.Add(notas);
        }

        //Creamos una función para calcular el promedio de los estudiantes y recibira unicamente la lista de notas del "Main"
        public double CalcularPromedio(List<double> notas)
        {
            //Creamos una variable la cual sumara todas las nota y estara inicializada en 0
            double suma = 0;
            //Usamos un bucle "foreach" para recorrer todas las notas registradas de cada estudiante
            foreach (var nota in notas)
            {
                //Conforme pasa el ciclo, se ira sumando cada nota y sera guardada en la variable de "suma"
                suma += nota;
            }
            //Regresamos al "Main" la suma de todas las notas entre la cantidad de notas que hubieron, que resulta en el promedio
            return suma / notas.Count;
        }

        //Creamos una función que determinara quien tiene el promedio más alto y bajo, recibiendo 2 listas
        public void DeterminarAltoBajoEstudiante(List<string> estudiantes, List<List<double>> calificaciones)
        {
            //Declaramos 2 variables tipo string que estaran vacias y ayudaran a almacenar los nombres de los dos estudiantes
            string estudiantemayor = "", estudiantemenor = "";
            //Declaramos otras dos que guardaran los promedios más alto, bajo y solo recibiran los resultados más altos y bajos
            double promediomayor = double.MinValue, promediomenor = double.MaxValue;

            //Con un ciclo "for" se ira verificando las calificaciones de cada estudiante registrado
            for (int i = 0; i < estudiantes.Count; i++)
            {
                //Conforme pase el ciclo, se crea una variable que guardara el promedio de cada estudiante registrado
                double promedio = CalcularPromedio(calificaciones[i]);

                //Usamos un "if" para verificar si el promedio que se revisa es mayor que el promedio más alto
                if (promedio > promediomayor)
                {
                    //Si lo es, se actualizan las variables antes declaradas para guardar los nuevos valores conforme pase el ciclo
                    promediomayor = promedio;
                    estudiantemayor = estudiantes[i];
                }

                //Usamos otro "if" para verificar si el promedio que se revisa es menor que el promedio más bajo
                if (promedio < promediomenor)
                {
                    //Si lo es, se actualizan las variables antes declaradas para guardar los nuevos valores conforme pase el ciclo
                    promediomenor = promedio;
                    estudiantemenor = estudiantes[i];
                }
            }

            //Una vez calculado todo, simplemente imprimimos los resultados de los procesos y son mostrados al usuario en el "Main"
            Console.WriteLine("");
            Console.WriteLine("Estudiante con Promedio Más Alto");
            Console.WriteLine("Nombre: {0} / Promedio: {1}", estudiantemayor, promediomayor);

            Console.WriteLine("");
            Console.WriteLine("Estudiante con Promedio Más Bajo");
            Console.WriteLine("Nombre: {0} / Promedio: {1}", estudiantemenor, promediomenor);
        }
    }
}