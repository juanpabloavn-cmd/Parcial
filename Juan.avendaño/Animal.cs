namespace ProyectoConsola.ClasesAbstractas
{
    public abstract class AnimalBase
    {
        public string Nombre { get; set; }

        public AnimalBase(string nombre)
        {
            Nombre = nombre;
        }

        public void MostrarNombre()
        {
            Console.WriteLine($"El animal se llama: {Nombre}");
        }

        // Puedes agregar métodos comunes si lo requieren
    }
}