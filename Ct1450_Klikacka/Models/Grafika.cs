namespace Ct1450_Klikacka.Models
{
    public class Grafika
    {
        public Grafika() 
        { 
            NaplnPole(radku: 8, sloupcu: 10, minCislo: 0, maxCislo: 1);
        }
        public Bunka[,] Pole { get; set; }
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

        public void OnCellClick(Models.Bunka bunka)
        {
            if (bunka.Hodnota == 0 && bunka.StyleClassIndex != ZvolenaBarva)
            {
                bunka.StyleClassIndex = ZvolenaBarva;
            }
            else
                bunka.StyleClassIndex = 0;
        }
    }
}
