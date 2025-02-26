//string[] notas = Console.ReadLine().Split(' ');

//float nota1 = float.Parse(notas[0]) * 2;
//float nota2 = float.Parse(notas[1]) * 3;
//float nota3 = float.Parse(notas[2]) * 4;
//float nota4 = float.Parse(notas[3]) * 1;

//float media = (nota1 + nota2 + nota3 + nota4) / 10;

//string formattedMedia = media.ToString("0.00");

//// Remover o último dígito da string formattedMedia
//formattedMedia = formattedMedia.Substring(0, formattedMedia.Length - 1);

//Console.WriteLine($"Média: {formattedMedia}");

//if (media >= 7)
//{
//    Console.WriteLine("Aluno aprovado.");
//}
//else if (media >= 5 && media <= 6.9)
//{
//    Console.WriteLine("Aluno em exame.");
//    float exame = float.Parse(Console.ReadLine());
//    Console.WriteLine($"Nota do exame: {exame:F1}");
//    float mediaFinal = (media + exame) / 2;

//    if (mediaFinal >= 5)
//    {
//        Console.WriteLine("Aluno aprovado.");
//        Console.WriteLine($"Media final: {mediaFinal:F1}");
//    }
//    else
//    {
//        Console.WriteLine("Aluno reprovado.");
//    }
//}
//else
//{
//    Console.WriteLine("Aluno reprovado.");
//}