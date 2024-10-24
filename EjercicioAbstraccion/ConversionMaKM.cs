namespace EjercicioAbstraccion
{
    public class ConversionMaKM : FormulaMatematica
    {
        public double Metros {  get; set; }
        public double Kilometros { get; set; }

        public ConversionMaKM(double Metros) { 
          this.Metros = Metros;
            this.Kilometros = Calcular();
        }

        public override double Calcular()
        {
            return Metros / 1000;
        }
        public override void imprimir()
        {
            Console.WriteLine($"{Metros} metros son {Kilometros} Kilómetros");
        }
    }
}
