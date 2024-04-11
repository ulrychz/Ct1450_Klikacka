namespace Ct1450_Klikacka.Models
{
    public class Bunka
    {
        public Bunka(int hodnota, int radek, int sloupec) 
        { 
            Hodnota = hodnota;
            Radek = radek;
            Sloupec = sloupec;
        }
        public int Hodnota { get; private set; }
        public int Radek { get; private set; }
        public int Sloupec { get; private set; }
        public int StyleClassIndex { get; set; } = 0;
        public virtual string StyleClassName => $"barva-{StyleClassIndex}";
    }
}
