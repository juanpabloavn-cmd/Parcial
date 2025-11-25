using System;
using ProyectoConsola.Modelos;

namespace ProyectoConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal oscar = new Animal("oscar");

            oscar.MostrarNombre();
            oscar.Comer();
            oscar.Dormir();
            oscar.HacerSonido();

            Console.WriteLine("Presiona una tecla para salir...");
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}


































// Clase Animal que hereda de SerVivo
class Animal : SerVivo
{
    public string Nombre { get; set; }
    public int Id { get; set; }

    // Constructor
    public Animal(string nombre, int id)
    {
        Nombre = nombre;
        Id = id;
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre del animal: {Nombre}");
        Console.WriteLine($"ID del animal: {Id}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creación del objeto llamado "oscar" con ID = 1
        Animal oscar = new Animal("Oscar", 1);

        // Llamamos métodos heredados y propios
        oscar.Respirar();
        oscar.MostrarDatos();

        Console.WriteLine("Presiona una tecla para salir...");
        Console.ReadKey();
    }
}