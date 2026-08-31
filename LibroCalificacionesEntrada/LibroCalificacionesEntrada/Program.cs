namespace LibroCalificacionesEntrada
{
    public class Program
    {
        static void Main(string[] args)
        {
            LibroCalificaciones myLibro = new LibroCalificaciones("CS101 Programación en C#");
            LibroCalificaciones myLibro2 = new LibroCalificaciones("CS102 Estructuras de Datos");
            Console.WriteLine("El nombre del curso es: {0}", myLibro.NombreCurso);
            Console.WriteLine("El nombre del curso es: {0}", myLibro2.NombreCurso);

            Console.WriteLine("\nEscriba el nombre del curso:");
            string elNombreCurso = Console.ReadLine();

            // Bucle de validación de entrada por consola
            while (string.IsNullOrWhiteSpace(elNombreCurso))
            {
                Console.WriteLine(" Error: El nombre ingresado no es válido. \n Escriba un nombre:");
                elNombreCurso = Console.ReadLine();
            }

            myLibro.NombreCurso = elNombreCurso;
            Console.WriteLine("el nombre del curso es: {0}", myLibro.NombreCurso);
        }
    }
}




