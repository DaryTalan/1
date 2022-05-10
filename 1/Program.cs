string[] arr =
{
    "hello",
    "2",
    "world",
    ":-)",
    "1234",
    "1567",
    "-2",
    "computer science",
    "Russia",
    "Denmark",
    "Kazan",
    "BY",
};
var result = new string[arr.Length];
var realSize = 0;
foreach (var value in arr)
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, result, 0, realSize));