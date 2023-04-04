// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] favFood = { "pizza", "lasagne", "spaghetti alla carbonara", "arrosto", "piadina", "crostata" };

Console.WriteLine($"You have {favFood.Length} favourite foods");

Console.WriteLine("Your favourite foods are");
for( int i = 0; i < favFood.Length; i++) 
    Console.WriteLine($"{i + 1}. {favFood[i]}" );

Console.WriteLine($"Your favourite food is {favFood[0]}");

Console.WriteLine($"Your not-so-favourite food is {favFood[favFood.Length - 1]}");