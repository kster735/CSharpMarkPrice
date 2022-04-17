// See https://aka.ms/new-console-template for more information
Console.Write("Hello ");
await Task.Delay(5000);
Console.WriteLine("World!");

int x;

Console.Write("Δώσε έναν ακέραιο: ");
x = Convert.ToInt32(Console.ReadLine());

int y;

Console.Write("Δώσε άλλον έναν ακέραιο: ");
y = Convert.ToInt32(Console.ReadLine());

int sum = x + y;

Console.WriteLine($"Το άθροισμα είναι: {sum}");
