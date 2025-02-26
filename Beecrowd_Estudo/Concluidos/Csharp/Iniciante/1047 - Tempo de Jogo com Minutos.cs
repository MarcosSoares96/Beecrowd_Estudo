//#region Main
//string[] valores = Console.ReadLine().Split(" ");

//int horaInicial = Convert.ToInt32(valores[0]);
//int minutoInicial = Convert.ToInt32(valores[1]);

//int horaFinal = Convert.ToInt32(valores[2]);
//int minutoFinal = Convert.ToInt32(valores[3]);

//TimeOnly horarioInicio = new TimeOnly(horaInicial, minutoInicial);

//TimeOnly horarioFinal = new TimeOnly(horaFinal, minutoFinal);

//TimeSpan duracao = horarioFinal - horarioInicio;
//int hora = 0;

//if (duracao.Hours == 0 && duracao.Minutes == 0)
//{
//    hora = 24;
//}
//else
//{
//    hora = duracao.Hours;
//}

//Console.WriteLine($"O JOGO DUROU {hora} HORA(S) E {duracao.Minutes} MINUTO(S)");

//Console.ReadLine();
//#endregion

/*Obs.: Novamente, temos que usar o DateTime:
    DateTime horarioInicio = new DateTime(1, 1, 1, horaInicial, minutoInicial, 0);
    DateTime horarioFinal = new DateTime(1, 1, 1, horaFinal, minutoFinal, 0);*/