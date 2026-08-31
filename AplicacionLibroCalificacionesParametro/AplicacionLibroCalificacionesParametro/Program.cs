using AplicacionLibroCalificacionesParametro;
using System;
namespace LibroCalificaciones_2
{
    public class LibroPuebaCalificaciones
    {
        static void Main(string[] args)
        {
        
            MiLibroCalificaciones MyLibro = new MiLibroCalificaciones();

            Console.Write("Por favor ingrese el nombre del curso: ");
            string entrada = Console.ReadLine();

            // Validación de entrada
            while (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine(" Error: Debe ingresar un nombre válido.");
                Console.Write("Por favor ingrese el nombre del curso: ");
                entrada = Console.ReadLine();
            }


            string nombreDelCurso = entrada;
            Console.WriteLine();

            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}


