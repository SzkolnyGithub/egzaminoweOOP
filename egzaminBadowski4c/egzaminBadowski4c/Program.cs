using System;

namespace egzaminBadowski4c
{
    /*******************************************************
        nazwa klasy: film
        pola: tytul - tytuł filmu
        liczbaWypozyczen - liczbę wypożyczeń filmu
        metody: ustawTytul, nic – ustawia zmienną tytuł
            getTytul - tytul - pokazuje wartość zmiennej tytul
            getLiczbaWypozyczen - liczbaWypozyczen - pokazuje wartość zmiennej liczbaWypozyczen
            wypozycz - nic - zwiększa wartość zmiennej liczbaWypozyczen o jeden
        informacje: klasa reprezentuje jakis film
        autor: 00000000
    ******************************************************/
    class film
    {
        protected string tytul;
        protected int liczbaWypozyczen;
        public film()
        {
            tytul = "";
            liczbaWypozyczen = 0;
        }
        public void ustawTytul(string temp)
        {
            tytul = temp;
        }
        public string getTytul()
        {
            return "Tytuł filmu to " + tytul;
        }
        public string getLiczbaWypozyczen()
        {
            return "Liczba wypożyczeń to " + liczbaWypozyczen;
        }
        public void wypozycz()
        {
            liczbaWypozyczen++;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            film test = new film();
            Console.Write(test.getTytul());
            Console.WriteLine();
            test.ustawTytul("john wick");
            Console.Write(test.getTytul());
            test.ustawTytul("Diuna");
            Console.WriteLine();
            Console.Write(test.getTytul());
            Console.WriteLine();
            Console.Write(test.getLiczbaWypozyczen());
            Console.WriteLine();
            Console.Write("Wywołanie funkcji wypozycz() zwiększa wartość zmiennej liczbaWypozyczen o jeden");
            Console.WriteLine();
            test.wypozycz();
            Console.Write(test.getLiczbaWypozyczen());
            Console.WriteLine();
        }
    }
}