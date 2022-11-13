
namespace Library
{
    public class EdadVisitor : Visitor
    {
        public int Contador {get;set;}
        public override void Visit(NodoPersona nodoPersona)
        {
            this.Contador += nodoPersona.Persona.Edad;
        }
    }
}