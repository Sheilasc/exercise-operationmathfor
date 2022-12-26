internal class Program
{
    private static void Main(string[] args)
    {
        int a = Leer("Ingrese Valor 1: ");
        int b = Leer("Ingrese Valor 2: ");
        string operacion = LeerOperacion (" Ingrese una operacion matematica a realizar: ");

        if ((operacion == "sumar") || (operacion == "suma") || (operacion == "s"))
        {
        //Sumar dos numeros
        int resultadoSuma = sumar (a,b);
        Console.WriteLine("El resultado de la suma de a + b es: "+resultadoSuma);
        }
        else if ((operacion == "restar") || (operacion == "resta") || (operacion == "r"))
        {
        //Restar dos numeros
        int resultadoResta = restar (a,b);
        Console.WriteLine("El resultado de la resta de a - b es: "+resultadoResta);
        }
        else if ((operacion == "multiplicar") || (operacion == "multiplicacion") || (operacion == "m"))
        {
        //Multiplicar dos numeros
        int resultadoMultiplicacion = multiplicacion (a,b);
        Console.WriteLine("El resultado de la multiplicacion de a * b es: "+resultadoMultiplicacion);
        }
        else if ((operacion == "dividir") || (operacion == "division") || (operacion == "d"))
        {
        //Dividir dos numeros
        decimal resultadodivision = division (a,b);
        Console.WriteLine("El resultado de la division de a / b es: "+resultadodivision); 
        }  
    }

    //Funcion Leer dos numeros
  public static int Leer(string mensaje)
  {
    for (int intentos = 0; intentos < 3; intentos++)
        {
            Console.WriteLine(mensaje);
            string numeroComoString = Console.ReadLine();
            int valorReal = 0;
            bool sePuedeConvertir = Int32.TryParse(numeroComoString, out valorReal);

            if (sePuedeConvertir)
            {
                return valorReal;
            }
            else
            {
                Console.WriteLine("valor ingresado invalido, intente de nuevo ...");
            }
        }

        throw new Exception("No se pude leer nada");
  }

  //Funcion Leer Operacion matematica
  public static string LeerOperacion(string mensaje)
  {
    
          Console.WriteLine(mensaje);
          string OperacionComoString = Console.ReadLine();
          string LowerOperation = OperacionComoString.ToLower();
          return LowerOperation;
     
  }

  //Funcion Sumar dos numeros
  public static int sumar(int a, int b)
  {
    int sumatotal = (a + b);
    return sumatotal;
  }

  //Funcion Restar dos numeros
  public static int restar(int a, int b)
  {
    int restatotal = (a - b);
    return restatotal;
  }

  //Funcion Multiplicar dos numeros
  public static int multiplicacion(int a, int b)
  {
    int multiplicaciontotal = (a * b);
    return multiplicaciontotal;
  }

  //Funcion Dividir dos numeros
  public static decimal division(int a, int b)
  {
    decimal divisiontotal = (Convert.ToDecimal (a) / Convert.ToDecimal (b));
    return divisiontotal;
  }
}