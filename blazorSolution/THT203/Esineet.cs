namespace THT203
{
    public class Esine
    {

       public string Nimi;
        public string Tyyppi;
        public double Arvo;
        public double Voima;
        public string TyyppiMsg;
        public Esine(string nimi, string tyyppi, int arvo, double voima)
        {
            Nimi = nimi;
            Tyyppi = tyyppi;
            Arvo = arvo;
            Voima = voima;
            if (tyyppi == "paino")
            {
                TyyppiMsg = "Lisä painalmusta";
            }
            else
            {
                TyyppiMsg = "Tausta painalmusta";
            }

        }
        public void LisaaArvoJaVoima()
        {
            Arvo *= 1.1;
            Voima *= 1.01;
        }
    }
}
