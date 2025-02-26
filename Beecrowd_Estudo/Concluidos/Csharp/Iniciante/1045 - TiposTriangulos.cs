//#region Main
//double[] entrada = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

//double[] valor = Ordenar(entrada);

//double A = valor[2];
//double B = valor[1];
//double C = valor[0];

//if (A > 0 && B > 0 && C > 0)
//{
//    TipoTriangulo(A, B, C);
//}

//Console.ReadLine();
//#endregion

//public static double[] Ordenar(double[] valor)
//{
//    Array.Sort(valor);

//    return valor;
//}

//public static void TipoTriangulo(double a, double b, double c)
//{
//    if (a >= b + c)
//    {
//        Console.WriteLine("NAO FORMA TRIANGULO");
//        return;
//    }
//    else
//    {
//        if (Math.Pow(a, 2) == (Math.Pow(b, 2) + Math.Pow(c, 2)))
//        {
//            Console.WriteLine("TRIANGULO RETANGULO");
//        }

//        if (Math.Pow(a, 2) > (Math.Pow(b, 2) + Math.Pow(c, 2)))
//        {
//            Console.WriteLine("TRIANGULO OBTUSANGULO");
//        }

//        if (Math.Pow(a, 2) < (Math.Pow(b, 2) + Math.Pow(c, 2)))
//        {
//            Console.WriteLine("TRIANGULO ACUTANGULO");
//        }

//        if (a == b && a == c)
//        {
//            Console.WriteLine("TRIANGULO EQUILATERO");
//        }

//        else if (a == b || a == c || b == c)
//        {
//            Console.WriteLine("TRIANGULO ISOSCELES");
//        }
//    }
//}