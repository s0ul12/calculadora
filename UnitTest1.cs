Console.WriteLine("CALCULADORA");
Console.WriteLine("");
Console.WriteLine("Elige que operación quieres hacer (solo numeros)");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("1: SUMA");
Console.WriteLine("2: RESTA");
Console.WriteLine("3: MULTIPLICACIÓN");
Console.WriteLine("4: DIVISIÓN");

String input = Console.ReadLine();
int selectedOption;
if(int.TryParse(input, out selectedOption))
{
      switch(selectedOption) 
      {
           case 1:
                 Console.WriteLine("Elige 2 numeros enteros que quieras sumar");
                 Console.WriteLine("Primer número:");
                 String suma1s = Console.ReadLine();
                 int suma1;
                 if(int.TryParse(suma1s, out suma1))
                 {
                    Console.WriteLine("Segundo Numero:");
                    String suma2s = Console.ReadLine();
                    int suma2;
                    if(int.TryParse(suma2s, out suma2))
                    {
                        Console.WriteLine("El resultado de la suma es: "+ (suma1+suma2));
                    }
                 }
                 break;
           case 2:
                 Console.WriteLine("Elige 2 numeros enteros que quieras sumar");
                 Console.WriteLine("Primer número:");
                 String resta1s = Console.ReadLine();
                 int resta1;
                 if(int.TryParse(resta1s, out resta1))
                 {
                    Console.WriteLine("Segundo Numero:");
                    String resta2s = Console.ReadLine();
                    int resta2;
                    if(int.TryParse(resta2s, out resta2))
                    {
                        Console.WriteLine("El resultado de la resta es: "+ (resta1-resta2));
                    }
                 }
                break;
            case 3:
                 Console.WriteLine("Elige 2 numeros enteros que quieras multiplicar");
                 Console.WriteLine("Primer número:");
                 String m1s = Console.ReadLine();
                 int m1;
                 if(int.TryParse(m1s, out m1))
                 {
                    Console.WriteLine("Segundo Numero:");
                    String m2s = Console.ReadLine();
                    int m2;
                    if(int.TryParse(m2s, out m2))
                    {
                        Console.WriteLine("El resultado de la multiplicación es: "+ (m1+m2));
                        
                    }
                 }
                 break;
            case 4:
                Console.WriteLine("Elige 2 numeros enteros que quieras sumar");
                 Console.WriteLine("Primer número:");
                 String d1s = Console.ReadLine();
                 int d1;
                 if(int.TryParse(d1s, out d1))
                 {
                    Console.WriteLine("Segundo Numero:");
                    String d2s = Console.ReadLine();
                    int d2;
                    if(int.TryParse(d2s, out d2))
                    {
                        Console.WriteLine("El resultado de la suma es: "+ (d1+d2));
                    }
                 }
                 break;
           
      }

} 
else
{
     Console.WriteLine("Solo se admiten números, vuelva a ejecutar la aplicación");
}