using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    // Del 3: Lagerstyringssystem
    public class Lager
    {
        private List<IProdukt> produkter = new List<IProdukt>();

        public void LeggTilProdukt(IProdukt produkt)
        {
            produkter.Add(produkt);
        }

        public void FjernProdukt(IProdukt produkt)
        {
            produkter.Remove(produkt);
        }

        public void ListOppProdukter()
        {
            Console.WriteLine("Produkter i lageret:");
            foreach (var produkt in produkter)
            {
                produkt.SkrivUtInfo();
            }
        }
    }
}
