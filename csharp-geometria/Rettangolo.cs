namespace Geometria
{
    internal class Rettangolo
    {
        private int baseRettangolo;
        private int altezzaRettangolo;

        public Rettangolo(int x, int y)
        { //costruttore
            this.baseRettangolo = x;
            this.altezzaRettangolo = y;
        }

        private int calcolaArea()
        {
            return baseRettangolo * altezzaRettangolo;
        }

        private int calcolaPerimetro()
        {
            return (baseRettangolo + altezzaRettangolo) * 2;
        }

        public void stampaRettangolo()
        {
            Console.WriteLine("—— Rettangolo1 ——");
            Console.WriteLine("Base: " + baseRettangolo + "cm");
            Console.WriteLine("Altezza: " + altezzaRettangolo + "cm");
            Console.WriteLine("Perimetro: " + calcolaPerimetro() + "cm");
            Console.WriteLine("Area: " + calcolaArea() + "cm2");
            Console.WriteLine("-----------------");
        }
    }
}