using System;
#region Main

//string[] lados = Console.ReadLine().Split(' ');

//double A = double.Parse(lados[0]);
//double B = double.Parse(lados[1]);
//double C = double.Parse(lados[2]);

//if (RetaA(A, B, C) && RetaB(A, B, C) && RetaC(A, B, C))
//{
//    double perimetro = A + B + C;
//    Console.WriteLine($"Perimetro = {perimetro:F1}");
//}
//else
//{
//    double area = ((A + B) * C) / 2;
//    Console.WriteLine($"Area = {area:F1}");
//}

//Console.ReadLine();
#endregion

//public static bool RetaA(double valorA, double valorB, double valorC)
//{
//    if (Math.Abs(valorB - valorC) < valorA && valorA < (valorB + valorC))
//    {
//        return true;
//    }
//    return false;
//}

//public static bool RetaB(double valorA, double valorB, double valorC)
//{
//    if (Math.Abs(valorA - valorC) < valorB && valorB < (valorA + valorC))
//    {
//        return true;
//    }
//    return false;
//}

//public static bool RetaC(double valorA, double valorB, double valorC)
//{
//    if (Math.Abs(valorA - valorB) < valorC && valorC < (valorA + valorB))
//    {
//        return true;
//    }
//    return false;
//}

/*ESTUDO:
 * É possivvel verificar os 3 valores e retornar como apelas um boolean. 
 * Desta forma, é possivel colocar apenas uma pergunta no if principal ao invés de 3 como eu fiz:
 
 *  public static bool ETriangulo(double a, double b, double c)
    {
        return Math.Abs(b - c) < a && a < (b + c) &&
               Math.Abs(a - c) < b && b < (a + c) &&
               Math.Abs(a - b) < c && c < (a + b);
    }

*/