namespace Ct1450_Klikacka.Models
{
    public class BunkaBarva : Bunka
    {
        public BunkaBarva( int sloupec) : base(hodnota: sloupec, radek:0, sloupec)
        {
            StyleClassIndex = sloupec;
        }
        public bool Selected { get; set; } = false;
        private string StyleClassNameSelected => Selected ? "selected" : "";
        //public override string StyleClassName => $"barva-{StyleClassIndex} {StyleClassNameSelected}";
        public override string StyleClassName => $"{base.StyleClassName} {StyleClassNameSelected}";

    }
}
