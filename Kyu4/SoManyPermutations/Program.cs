//In this kata, your task is to create all permutations of a non-empty input string and remove duplicates, if present.

//    Create as many "shufflings" as you can!

//Examples:

//With input 'a':
//Your function should return: ['a']

//With input 'ab':
//Your function should return ['ab', 'ba']

//With input 'abc':
//Your function should return ['abc','acb','bac','bca','cab','cba']

//With input 'aabb':
//Your function should return ['aabb', 'abab', 'abba', 'baab', 'baba', 'bbaa']
//Note: The order of the permutations doesn't matter.

//    Good luck!

Console.WriteLine(string.Join(",", Permutations("aabb")));

Console.ReadKey();

static List<string> Permutations(string s)
{
    if (s.Length == 1)
    {
        return new[] { s }.ToList();
    }
    else
    {
        return Permutations(s[1..]).SelectMany(permutation =>
            Enumerable.Range(0, s.Length).Select(index =>
                permutation.Insert(index, s[0].ToString()))).GroupBy(x => x).Select(x => x.First()).ToList();
    }
}