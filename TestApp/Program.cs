// Задание выполнено примерно за полтора-два часа, при этом, по большому счету, времени 
// больше ушло на обдумывание того, насколько сложным мне сделать код; принято решение
// написать простым топорным методом + написал тесты (функцию и класс продублировал в проекте тестов)
//
//
// Алгоритмическая сложность: емкостная сложность O(n), временная сложность O(n)

string FormRoute(List<Path> citiesPairs)
{
    var output = new List<string>();

    for (int i = citiesPairs.Count - 1; i >= 0; i--)
    {
        if (!output.Contains(citiesPairs[i].From))
            output.Add(citiesPairs[i].From);

        if (!output.Contains(citiesPairs[i].To))
            output.Add(citiesPairs[i].To);
    }

    return String.Join(" ", output.ToArray());
}



var pairsCount = Convert.ToInt32(Console.ReadLine());
var pairs = new List<Path>(pairsCount);

for (int i = 0; i < pairsCount; i++)
{
    var input = Convert.ToString(Console.ReadLine()).Split(" ");
    pairs.Add(new Path() { From = input[0], To = input[1] });
}

var output = FormRoute(pairs);
Console.WriteLine(output);



public class Path
{
    public string From { get; set; }
    public string To { get; set; }
}



