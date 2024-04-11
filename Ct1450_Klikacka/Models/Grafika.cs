namespace Ct1450_Klikacka.Models
{
    public class Grafika
    {
        public Grafika() 
        { 
            NaplnPole(radku: 8, sloupcu: 10, minCislo: 0, maxCislo: 1);
        }
        public Grafika(int pocetBarev, int pocetRadek, int pocetSloupcu)
        {
            PripravBarvy(pocetBarev);
            NaplnPole(radku: pocetRadek, sloupcu: pocetSloupcu, minCislo: 0, maxCislo: pocetBarev);
            
            ZvolenaBarva = 3;
            BarvySeznam[ZvolenaBarva].Selected = true;
        }
        public Bunka[,] Pole { get; private set; }
        public List<BunkaBarva> BarvySeznam { get; private set; } = new List<BunkaBarva>();
        private int ZvolenaBarva { get; set; } = 3;

        private Random random = new Random();
        private void NaplnPole(int radku, int sloupcu, int minCislo, int maxCislo)
        {
            Pole = new Bunka[radku, sloupcu];
            for (int i = 0; i < radku; i++)
            {
                for (int j = 0; j < sloupcu; j++)
                {
                    Pole[i,j] = new Bunka(random.Next(minCislo, maxCislo+1), radek: i, sloupec: j);
                }
            }
        }
        private void PripravBarvy(int pocetBarev)
        {
            for (int i = 0; i <= pocetBarev; i++)
            {
                BarvySeznam.Add(new BunkaBarva(i));
            }
        }
        public void OnCellClick(Models.Bunka bunka)
        {
            if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva || BarvySeznam.Any())
            {
                bunka.StyleClassIndex = ZvolenaBarva;
            }
            else
                bunka.StyleClassIndex = 0;
        }
        public void OnCellClick(Models.BunkaBarva bunka)
        {
            foreach (var item in BarvySeznam)
            {
                item.Selected = false;
            }
            bunka.Selected = true;
            ZvolenaBarva = bunka.Hodnota;
        }
    }
}
