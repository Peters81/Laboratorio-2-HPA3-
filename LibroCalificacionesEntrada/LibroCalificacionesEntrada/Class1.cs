using System;

public class LibroCalificaciones
{
    private string nombreCurso;

    public LibroCalificaciones(string nombre)
    {
        nombreCurso = nombre;
    }

    public string NombreCurso
    {
        get { return nombreCurso; }
        set
        {  
            if (string.IsNullOrWhiteSpace(value))
            {
                nombreCurso = "Sin Asignar";
            }
            else if (value.Length > 30) 
            {
                nombreCurso = value.Substring(0, 30); 
            }
            else
            {
                nombreCurso = value;
            }
        }
    }

    public void MostrarMensaje()
    {
        Console.WriteLine("Bienvenido al libro de calificaciones para: \n{0}!", NombreCurso);
    }
}



