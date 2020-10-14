using Bundesbank.Rc.Konto.Konten;
using Bundesbank.Rc.Konto.Konten.Visitors;
using System;
using System.Security.Principal;

namespace Bundesbank.Rc.Konto.Konten
{
    class Program
    {
        static void Main(string[] args)
        {
            Kontogruppe K1 = new Kontogruppe("K1");
            Kontogruppe K2 = new Kontogruppe("K2");
            K1.AppendChild(K2);

            Konto K3 = new Konto("K3");
            K1.AppendChild(K3);

            K1.Iterate(new PrintVisitor());
            K3.Iterate(new PrintVisitor());
            K2.Iterate(new PrintVisitor());
        }
    }
}
