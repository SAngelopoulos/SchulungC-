using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc.Konto.Konten.Visitors
{
    public class PrintVisitor : IKontonodeVisitor
    {
        public void Visit(Kontogruppe kontogruppe)
        {
            Console.WriteLine(kontogruppe);
        }

        public void Visit(Konto konto)
        {
            Console.WriteLine(konto);
        }
    }

}
