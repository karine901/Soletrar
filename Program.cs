using System.Security.Cryptography;

Console.Clear();

Console.WriteLine("soletrando\n");
Console.Write("digite o texto a ser soletrando:");

string texto = Console.ReadLine()!;

Console.WriteLine("\nsoletrando ficaria...\n");

Console.WriteLine(string.Join("-",texto.ToUpper().ToCharArray()));

Console.WriteLine();