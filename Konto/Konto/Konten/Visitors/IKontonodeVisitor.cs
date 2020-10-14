using Bundesbank.Rc.Konto.Konten;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc.Konto.Konten.Visitors
{
    public interface IKontonodeVisitor
    {
        public void Visit(Kontogruppe kontogruppe);
        public void Visit(Konto konto);

        public virtual void Init()
        {

        }
        public virtual void Finish()
        {

        }

    }
}
