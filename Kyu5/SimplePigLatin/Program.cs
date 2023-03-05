
using System.Text.RegularExpressions;

public class Res
{
    public string Resolve(string input)
    {
        return string.Join(" ", input.Split(" ").Select(x =>
        {
            string word = new(x.ToCharArray().Where(char.IsLetterOrDigit).ToArray());

            if (word.Length == 0)
            {
                return x;
            }

            return $"{x.Substring(1, word.Length - 1)}{x[0]}ay{x.Substring(word.Length - 1, x.Length - word.Length)}";
        }));
    }

    // Solution of https://www.codewars.com/users/theanonym
    public static string PigIt(string str) => Regex.Replace(str, @"((\S)(\S+))", "$3$2ay");
}

