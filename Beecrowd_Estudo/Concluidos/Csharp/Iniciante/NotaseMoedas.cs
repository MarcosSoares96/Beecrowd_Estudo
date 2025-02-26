//double valor = Convert.ToDouble(Console.ReadLine());

//if (valor >= 0 && valor <= 1000000.00)
//{
//    double valorInicial = valor;
//    int Notas = (int)valor / 1;
//    double Moedas = ((valorInicial - Notas) * 100);

//    //Notas
//    int nota100 = (int)valor / 100;
//    int nota50 = (int)(valor %= 100) / 50;
//    int nota20 = (int)(valor %= 50) / 20;
//    int nota10 = (int)(valor %= 20) / 10;
//    valor %= 10;
//    int nota5 = (int)(valor %= 10) / 5;
//    int nota2 = (int)(valor %= 5) / 2;

//    //Moedas
//    int moeda1 = (int)(valor %= 2) / 1;
//    int moeda50 = (int)Moedas / 50;
//    int moeda25 = (int)(Moedas %= 50) / 25;
//    int moeda10 = (int)(Moedas %= 25) / 10;
//    int moeda05 = (int)(Moedas %= 10) / 5;
//    int moeda01 = (int)(Moedas %= 5) / 1;

//    Console.WriteLine($"NOTAS:");
//    Console.WriteLine($"{nota100} nota(s) de R$ 100.00");
//    Console.WriteLine($"{nota50} nota(s) de R$ 50.00");
//    Console.WriteLine($"{nota20} nota(s) de R$ 20.00");
//    Console.WriteLine($"{nota10} nota(s) de R$ 10.00");
//    Console.WriteLine($"{nota5} nota(s) de R$ 5.00");
//    Console.WriteLine($"{nota2} nota(s) de R$ 2.00");
//    Console.WriteLine($"MOEDAS:");
//    Console.WriteLine($"{moeda1} moeda(s) de R$ 1.00");
//    Console.WriteLine($"{moeda50} moeda(s) de R$ 0.50");
//    Console.WriteLine($"{moeda25} moeda(s) de R$ 0.25");
//    Console.WriteLine($"{moeda10} moeda(s) de R$ 0.10");
//    Console.WriteLine($"{moeda05} moeda(s) de R$ 0.05");
//    Console.WriteLine($"{moeda01} moeda(s) de R$ 0.01");
//}
//else
//{
//    Console.WriteLine("Valor inválido");
//}

//Console.ReadKey();