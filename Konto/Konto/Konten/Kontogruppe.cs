using Bundesbank.Rc.Konto.Konten.Visitors;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Bundesbank.Rc.Konto.Konten
{
   public class Kontogruppe : AbstractKontonode
    {
        private IList<AbstractKontonode> Children { get; set; }
        public Kontogruppe(string kontonummer):base(kontonummer)
        {
            Children = new List<AbstractKontonode>();
        }

        public override IList<AbstractKontonode> GetChildren()
        {
            return new ReadOnlyCollection<AbstractKontonode>(Children);
        }

        public virtual void AppendChild (AbstractKontonode child)
        {
            child.Parent = this;
            Children.Add(child);
        }
        public virtual void RemoveChild(AbstractKontonode child)
        {
            child.Parent = null;
            Children.Remove(child);
        }

        public override string ToString()
        {
            return $"Kontogruppe: Kontonummer = { Kontonummer}";
        }

        public override void Accept(IKontonodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
