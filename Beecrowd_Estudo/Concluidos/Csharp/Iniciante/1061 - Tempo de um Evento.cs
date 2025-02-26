//#region Main
//Console.Write("Dia ");
//int diaInico = Convert.ToInt32(Console.ReadLine());
//string horarioInicio = Console.ReadLine().Replace(" ", "");
//Console.Write("Dia ");
//int diaFim = Convert.ToInt32(Console.ReadLine());
//string horarioFim = Console.ReadLine().Replace(" ", "");

//DateTime DiaHoraInico = DateTime.Parse($"{diaInico}/04/{DateTime.Now.Year} {horarioInicio}");

//DateTime DiaHoraFim = DateTime.Parse($"{diaFim}/04/{DateTime.Now.Year} {horarioFim}");

////Usando Abril como mês, pois o problema especifica que o evento é em Abril)

//TimeSpan duracao = DiaHoraFim - DiaHoraInico;

//DateTime date = new DateTime(DateTime.Parse(), TimeOnly.Parse(horarioInicio));

//        Console.WriteLine($"{duracao.Days} dia(s)");
//Console.WriteLine($"{duracao.Hours} hora(s)");
//Console.WriteLine($"{duracao.Minutes} minuto(s)");
//Console.WriteLine($"{duracao.Seconds} segundo(s)");

////Obs.: Em console este programa roda, porém para a resolução do site há uma exceção devido a formato da data que segue outro padrão.
//// Para resolver isso use o DateTime:
//// DateTime(DateTime.Now.Year, 4, dia, horas, minutos, segundos);

//Console.ReadLine();
//#endregion