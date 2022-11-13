using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class NodoPersona
    {
        private Persona persona;

        private List<NodoPersona> hijos = new List<NodoPersona>();

        public Persona Persona {
            get
            {
                return this.persona;
            }
        }

        public ReadOnlyCollection<NodoPersona> Hijos { 
            get
            {
                return this.hijos.AsReadOnly();
            }
        }

        public NodoPersona(Persona persona)
        {
            this.persona = persona;
        }

        public void AddHijos(NodoPersona n)
        {
            this.hijos.Add(n);
        }
        
        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}