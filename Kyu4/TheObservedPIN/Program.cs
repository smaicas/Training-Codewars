// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Res.GetPINs("11");

public class Res
{
    public static List<string> GetPINs(string observed) => Resolve(observed);

    private static readonly Dictionary<char, char[]> Posible = new()
    {
        {'1', new char[] { '2', '4', '1'}},
        {'2', new char[] { '1', '3', '5', '2'}},
        {'3', new char[] { '2', '6', '3'}},
        {'4', new char[] { '1', '5', '7', '4'}},
        {'5', new char[] { '2', '4', '6', '8', '5'}},
        {'6', new char[] { '3', '5', '9', '6'}},
        {'7', new char[] { '4', '8', '7'}},
        {'8', new char[] { '5', '7', '9', '0', '8'}},
        {'9', new char[] { '6', '8', '9'}},
        {'0', new char[] { '8', '0'}},
    };

    // Solucion de Luis Llamas
    static IEnumerable<string> CalculateCombinations(List<string> original, char[] newItems)
    {
        return original.Any() ? original.SelectMany((x) => newItems, (x, y) => $"{x}{y}")
            : newItems.Select(x => x.ToString());
    }

    static List<string> Resolve(string pin)
    {
        List<string> rst = new();

        foreach (char item in pin)
        {
            rst = CalculateCombinations(rst, Posible[item]).ToList();
        }
        return rst;
    }
}