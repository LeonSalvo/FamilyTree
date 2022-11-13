using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Node n1 = new Node(1);
            Node n2 = new Node(2);
            Node n3 = new Node(3);
            Node n4 = new Node(4);
            Node n5 = new Node(5);
            Node n6 = new Node(6);
            Node n7 = new Node(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7); */
            NodoPersona abuelo1 = new NodoPersona(new Persona("Abuelo1", 78));
            NodoPersona abuela1 = new NodoPersona(new Persona("Abuela1", 79));

            NodoPersona abuelo2 = new NodoPersona(new Persona("Abuelo2", 80));
            NodoPersona abuela2 = new NodoPersona(new Persona("Abuela2", 79));

            NodoPersona madre = new NodoPersona(new Persona("Madre", 45));
            NodoPersona padre = new NodoPersona(new Persona("Padre", 48));

            abuela1.AddHijos(padre);
            abuelo1.AddHijos(padre);
            abuela2.AddHijos(madre);
            abuelo2.AddHijos(madre);


            NodoPersona tio = new NodoPersona(new Persona("Tio", 40));
            abuela1.AddHijos(tio);
            abuelo1.AddHijos(tio);

            NodoPersona yo = new NodoPersona(new Persona("Leon Salvo", 19));
            padre.AddHijos(yo);
            madre.AddHijos(yo);

            // visitar el árbol aquí

            EdadVisitor visitor1 = new EdadVisitor();
            abuelo1.Accept(visitor1);
            abuelo2.Accept(visitor1);
            abuela1.Accept(visitor1);
            abuela1.Accept(visitor1);
            padre.Accept(visitor1);
            madre.Accept(visitor1);
            tio.Accept(visitor1);
            yo.Accept(visitor1);

            Console.WriteLine(visitor1.Contador);

            EdadMaximaVisitor visitor2 = new EdadMaximaVisitor();
            abuelo1.Accept(visitor2);
            abuelo2.Accept(visitor2);
            abuela1.Accept(visitor2);
            abuela1.Accept(visitor2);
            padre.Accept(visitor2);
            madre.Accept(visitor2);
            tio.Accept(visitor2);
            yo.Accept(visitor2);

            Console.WriteLine(visitor2.Maxima);

            NombreVisitor visitor3 = new NombreVisitor();
            abuelo1.Accept(visitor3);
            abuelo2.Accept(visitor3);
            abuela1.Accept(visitor3);
            abuela1.Accept(visitor3);
            padre.Accept(visitor3);
            madre.Accept(visitor3);
            tio.Accept(visitor3);
            yo.Accept(visitor3);

            Console.WriteLine(visitor3.Largo);
            
        }
    }
}
