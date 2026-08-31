using AplicacionLibroCalificaciones;
using System;
namespace AplicacionLibroCalificaciones
{
    public class PruebaLibroCalificaciones
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            LibroCalificaciones MyLibro = new LibroCalificaciones();


            string nombreDelCurso;
            do
            {
                Console.Write("Por favor ingrese el nombre del curso: ");
                nombreDelCurso = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(nombreDelCurso))
                {
                    Console.WriteLine(" Error: El nombre del curso no puede estar vacío. Intente de nuevo.\n");
                }
            }
            while (string.IsNullOrWhiteSpace(nombreDelCurso));

            Console.WriteLine();



            MyLibro.MostrarMensaje();
        }
    }
}

