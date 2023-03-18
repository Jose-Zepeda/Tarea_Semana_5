
using System;
using System.Linq;
using System.Numerics;


try
{
    //CALCULAR EL ÁREA DE UN CIRCULO

    static float area_circulo(float radio)
    {
        float area = (float)(3.1416 * Math.Pow(radio , 2));
        return area;
    }

    //CALCULAR EL PERIMETRO DE UN RECTANGULO

    static float perimetro_rectangulo(float ancho, float altura)
    {
        float perimetro = (float)((ancho + ancho) + (altura + altura));
        return perimetro;
    }

    //CALCULAR PROMEDIO DE LISTA DE NÚMEROS

    static int Promedio_enteros(int[] listanum)
    {
        if (listanum.Length == 0)
        {
            return 0;
        }
        else
        {
            return listanum.Sum() / listanum.Length;
        }

    }

    //CALCULAR SI EL NUMERO ES PAR O IMPAR

    static string par_impar(int num)
    {
        if (num % 2 == 0)
        {
            return "El número es par";
        }
        else
        {
            return "El número es impar";
        }
    }

    //CONVERTIR UNA CADENA A MAYUSCULA

    static string ConvertirMayu (string cadena)
    {
        return cadena.ToUpper();
    }
    
    //CALCULAR LA DISTANCIA ENTRE 2 PUNTOS EN UN PLANO CARTESIANO

    static float CalcularDistancia (float x1, float x2, float y1, float y2)
    {
        return (float)Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
    }

    //CALCULAR LA SUMA DE LOS PRIMEROS N NATURALES

    static int SumaNaturales (int numero)
    {
        int suma = 0;
        for (int i = 1; i <= numero; i++)
        {
            suma += i;
        }
        return suma;
    }

    //CALCULAR EL FACTORIAL DE UN NÚMERO

    static BigInteger Factorial (int numero)
    {
        BigInteger factorial = 1;

        for (int i = 1; i <= numero; i++)
        {
            factorial *= i;
        }
        return factorial;
    }

}
catch
{
    Console.Write("Introduzca datos válidos");
}
    
