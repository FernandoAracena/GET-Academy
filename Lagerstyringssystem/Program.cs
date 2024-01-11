using System;
using System.Collections.Generic;
using Lagerstyringssystem;

// Del 4: Hovedprogram (Main)
class Program
{
    static void Main()
    {
        Lager lager = new Lager();

        Elektronikk elektronikk1 = new Elektronikk { Navn = "Smarttelefon", Pris = 5000, Garantitid = 12 };
        Elektronikk elektronikk2 = new Elektronikk { Navn = "Laptop", Pris = 8000, Garantitid = 24 };

        Matvare matvare1 = new Matvare { Navn = "Melk", Pris = 20, Utløpsdato = DateTime.Now.AddDays(7) };
        Matvare matvare2 = new Matvare { Navn = "Brød", Pris = 30, Utløpsdato = DateTime.Now.AddDays(5) };

        Klær klær1 = new Klær { Navn = "T-skjorte", Pris = 100, Størrelse = "L" };
        Klær klær2 = new Klær { Navn = "Jeans", Pris = 150, Størrelse = "M" };

        lager.LeggTilProdukt(elektronikk1);
        lager.LeggTilProdukt(elektronikk2);
        lager.LeggTilProdukt(matvare1);
        lager.LeggTilProdukt(matvare2);
        lager.LeggTilProdukt(klær1);
        lager.LeggTilProdukt(klær2);

        Console.WriteLine("---- Før fjerning av produkt ----");
        lager.ListOppProdukter();

        // Fjern et produkt fra lageret
        lager.FjernProdukt(elektronikk1);

        Console.WriteLine("---- Etter fjerning av produkt ----");
        lager.ListOppProdukter();
    }
}
