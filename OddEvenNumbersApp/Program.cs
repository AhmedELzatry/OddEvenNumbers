using System.Linq;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

PrintNumbers("IS EVEN", numbers.Where(x => x % 2 == 0));
PrintNumbers("IS ODD", numbers.Where(x => x % 2 != 0));

Console.WriteLine("\n\n\t\tREFACTOR");

static void PrintNumbers (string title,IEnumerable<int> numbers)
{
    Console.WriteLine();
    Console.Write($"{title}: [");
    foreach (int number in numbers)
    {  Console.Write($" {number}"); }
    Console.Write(" ]");
    Console.WriteLine();
}