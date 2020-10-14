using Bundesbank.Rc.Konto.Konten.Visitors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc.Konto.Konten
{
    public class Konto : AbstractKontonode
    {
        public double Saldo { get; set; }
        public Konto(string kontonummer) : base(kontonummer)
        {
            Saldo = 5;
        }

        public override string ToString()
        {
            return $"Konto: Kontonummer = { Kontonummer}, Saldo = {Saldo}";
        }

        public override void Accept(IKontonodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
