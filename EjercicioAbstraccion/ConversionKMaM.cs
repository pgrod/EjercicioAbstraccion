namespace EjercicioAbstraccion
{
    public class ConversionKMaM : FormulaMatematica
    {
        public double Km { get; set; }
        public double M { get; set; }

        public ConversionKMaM(double Km) { 
          this.Km = Km;
            this.M = Calcular();
        }

        public override double Calcular()
        {
            return Km * 1000;
        }

        public override void imprimir()
        {
            Console.WriteLine($"{Km} kilómetros son {M} metros.");
        }
    }
}
