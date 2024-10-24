namespace EjercicioAbstraccion
{
    public class ConversionMillasAKM : FormulaMatematica
    {
        public double Millas {  get; set; }
        public double Km {  get; set; }

        public ConversionMillasAKM(double millas)
        {
            this.Millas = millas;
        }
        public override double Calcular()
        {
            return Millas * 1.60;
        }
        public override void imprimir()
        {
            Console.WriteLine($"{Millas} millas son {Km} Kil");
        }
    }
}
