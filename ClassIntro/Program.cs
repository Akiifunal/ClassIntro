namespace ArabaCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba();
            araba1.arabaAdi = "Ford";
            araba1.fiyat = 700000;
            araba1.renk = "siyah";

            Araba araba2 = new Araba();
            araba2.arabaAdi = "Fiat";
            araba2.fiyat = 800000;
            araba2.renk = "siyah";

            Araba[] arabalar = new Araba[] { araba1, araba2 };
            foreach (var Araba in arabalar)
            {
                Console.WriteLine(Araba.arabaAdi + ":" + Araba.fiyat);
            }
            for (int i = 0; i < arabalar.Length; i++)
            {
                Console.WriteLine(arabalar[i].arabaAdi + ":" +
                arabalar[i].fiyat);
            }
            int j = 0;
            while (j < 3)
            {
                Console.WriteLine(arabalar[j].arabaAdi + ":" +
                arabalar[j].fiyat);
                j++;
               
            }
        }

    }
    class Araba
    {
        public string arabaAdi { get; set; }
        public int fiyat { get; set; }
        public string renk { get; set; }
    }
}
