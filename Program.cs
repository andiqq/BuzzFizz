using static System.Console;
using System.Linq;

Enumerable.Range(1, 50)
    .Select(i => (i % 3, i % 5) switch
    {
        (0, 0) => "BuzzFizz",
        (0, _) => "Buzz",
        (_, 0) => "Fizz",
        _ => i.ToString()
    })
    .ToList()
    .ForEach(output => Write($"{output} "));
WriteLine();