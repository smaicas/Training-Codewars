public class Res
{
    public int[] Resolve(int[] input) => input.Where(x => x > 0).Concat(input.Where(x => x == 0)).ToArray();
}