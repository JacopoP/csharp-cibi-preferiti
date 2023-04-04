// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] favFood = { "pizza", "lasagne", "spaghetti alla carbonara", "acqua", "arrosto", "piadina", };

Console.WriteLine($"You have {favFood.Length} favourite foods");

Console.WriteLine("Your favourite foods are");
for( int i = 0; i < favFood.Length; i++) 
    Console.WriteLine($"{i + 1}. {favFood[i]}" );

Console.WriteLine($"Your favourite food is {favFood[0]}");

Console.WriteLine($"Your not-so-favourite food is {favFood[favFood.Length - 1]}");

if (favFood.Length % 2 == 0)
    Console.WriteLine($"Your medium favourite foods are {favFood[favFood.Length / 2]} and {favFood[favFood.Length / 2 - 1]}");
else
    Console.WriteLine($"Your medium favourite food is {favFood[favFood.Length / 2]}");