using System.Reflection;

Console.Title = Assembly.GetExecutingAssembly().GetName().Name ?? "Builder";
Console.ForegroundColor = ConsoleColor.Green;