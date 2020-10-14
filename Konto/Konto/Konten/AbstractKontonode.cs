using Bundesbank.Rc.Konto.Konten.Visitors;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Bundesbank.Rc.Konto.Konten
{
    public abstract class AbstractKontonode : IEnumerable<AbstractKontonode>
    {
        public string Kontonummer { get; set; }
        public AbstractKontonode Parent { get; set; }

        public AbstractKontonode(string kontonummer)
        {
            Kontonummer = kontonummer;
            Parent = null;
        }

        public virtual IList<AbstractKontonode> GetChildren()
        {
            return new List<AbstractKontonode>().AsReadOnly();
        }

        public override string ToString()
        {
            return $"AbstractKontonode: Kontonummer = {Kontonummer}";
        }

        public IEnumerator<AbstractKontonode> GetEnumerator()
        {
            IList<AbstractKontonode> myList = new List<AbstractKontonode>();
            GetEnumeratorImpl(myList);
            return myList.GetEnumerator();
        }
        private void GetEnumeratorImpl(IList<AbstractKontonode> liste)
        {
            liste.Add(this);
            foreach (var child in GetChildren())
            {
                child.GetEnumeratorImpl(liste);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public virtual void Print()
        {
            foreach (var Node in this)
            {
                Console.WriteLine(Node);
            }
        }
        public abstract void Accept(IKontonodeVisitor visitor);
        public void Iterate(IKontonodeVisitor visitor)
        {
            foreach (var node in this)
            {
                node.Accept(visitor);
            }
        }
    }
}
