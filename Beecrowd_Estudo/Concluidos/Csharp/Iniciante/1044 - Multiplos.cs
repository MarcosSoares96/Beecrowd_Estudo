//#region Main
//string[] valores = Console.ReadLine().Split(' ');

//int A = Convert.ToInt32(valores[0]);
//int B = Convert.ToInt32(valores[1]);

//if (EMultiplo(A, B))
//{
//    Console.WriteLine("Sao Multiplos");
//}
//else
//{
//    Console.WriteLine("Nao sao Multiplos");
//}

//Console.ReadLine();
//#endregion

//public static bool EMultiplo(int A, int B)
//{
//    if (A > B)
//    {
//        return A % B == 0;
//    }
//    else if (A < B)
//    {
//        return B % A == 0;
//    }
//    return false;
//}

/*ESTUDO:
 * Novamente, � possivvel simplificar a pergunta para apenas um boolean. 
 * Desta forma, a fun��o ja verifica se o resultado da divis�o entre os numeros � inteira ou n�o:

 *  public static bool IsMultiple(int a, int b)
    {
        return a % b == 0 || b % a == 0;
    }

*/