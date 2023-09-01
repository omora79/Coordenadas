// Lea las coordenadas de dos puntos y que muestre la distancia entre los dos puntos.

// 1 crear clase y metodo

public class Coordenadas
{

    static void Main(string[] Args)
    {

        // 2 definer las variables
        double x1, x2, y1, y2;
        double d;
        
        Console.WriteLine("Ingrese el valor de x1: ");
        x1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de y1: ");
        y1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de x2: ");
        x2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de y2: ");
        y2 = Convert.ToDouble(Console.ReadLine());

        // 3 hacer los calculos

        d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) );

        //4 mostara en pantalla

        Console.WriteLine("la distancia entre " + x1 + " , " + y1 + " y " + x2 + " , " + y2 + " es: " + d);

    }


}   