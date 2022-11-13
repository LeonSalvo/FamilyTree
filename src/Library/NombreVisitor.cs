namespace Library
{
    public class NombreVisitor : Visitor
    {
        public string Largo {get;set;}
        public NombreVisitor()
        {
            this.Largo = "";
        }
        public override void Visit(NodoPersona nodoPersona)
        {
            if (nodoPersona.Persona.Nombre.Length > this.Largo.Length)
            {
                this.Largo = nodoPersona.Persona.Nombre;
            }
        }
    }
}