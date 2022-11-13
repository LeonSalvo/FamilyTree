namespace Library
{
    public class EdadMaximaVisitor : Visitor
    {
        public int Maxima {get;set;}
        public override void Visit(NodoPersona nodoPersona)
        {
            if (nodoPersona.Persona.Edad > this.Maxima && nodoPersona.Hijos.Count == 0)
            {
            this.Maxima += nodoPersona.Persona.Edad;
            }
        }
    }
}