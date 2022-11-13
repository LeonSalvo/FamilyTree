
namespace Library
{
    public class Persona
    {
        public string Nombre {get;set;}
        public int Edad {get;set;}

        public Persona(string nombre, int edad)
        {
            this.Edad = edad;
            this.Nombre = nombre;
        }
    }
}