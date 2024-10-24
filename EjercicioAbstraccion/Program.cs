using EjercicioAbstraccion;

FormulaMatematica formula = null;
int opcion;

Console.WriteLine("***********Menú***********");
Console.WriteLine("Seleccione una opción: ");
Console.WriteLine("1. Convertir Kilómetros a metros");
Console.WriteLine("2. Convertir metros a kilómetros");
Console.WriteLine("3. Convertir millas a kilómetros");
opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
switch (opcion)
{
    case 1:
        Console.WriteLine("Ingrese la cantidad de kilómetros: ");
        double kilometros = Convert.ToDouble(Console.ReadLine());
        formula = new ConversionKMaM(kilometros);
        break;
    case 2:
        Console.WriteLine("Ingrese la cantidad de metros: ");
        double Metros = Convert.ToDouble(Console.ReadLine());
        formula = new ConversionMaKM(Metros);
        break;
    case 3:
        Console.WriteLine("Ingrese la cantidad de millas: ");
        double Millas = Convert.ToDouble(Console.ReadLine());
        formula = new ConversionMillasAKM(Millas);
        break;
    default:
        Console.WriteLine("BYE");
        break;

}

formula.Calcular();
formula.imprimir();


    

