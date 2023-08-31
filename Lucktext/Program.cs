// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("What is ur name?");
string name = Console.ReadLine();
Console.WriteLine("what is yums?");
string lame = Console.ReadLine();
Console.WriteLine("how are u?");
string game = Console.ReadLine();

Console.WriteLine($"hey {name} cool name, mm {lame} is indeed very yummers. u feel {game}? Thats unfortunate..");
Console.ReadLine();