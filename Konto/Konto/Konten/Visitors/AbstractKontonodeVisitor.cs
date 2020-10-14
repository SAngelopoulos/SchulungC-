using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc.Konto.Konten.Visitors
{
    public abstract class AbstractKontonodeVisitor : IKontonodeVisitor

    {
        public virtual void Visit(Kontogruppe kontogruppe)
        {
       
        }

        public virtual void Visit(Konto konto)
        {

        }
        public virtual void Init()
        {

        }
        public virtual void Finish()
        {

        }
    }
}
