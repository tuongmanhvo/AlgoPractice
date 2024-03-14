/// <summary>
/// Given a string and a pattern,
/// find the smallest substring in the given string which has all the characters of the given pattern.
/// </summary>
public class Helper
{
    public static Dictionary<char, int> BuildFrequencyFromPattern(string pattern) =>
            pattern.Aggregate(new Dictionary<char, int>(), (map, c) =>
            {
                map.TryAdd(c, 0);
                map[c] += 1;
                return map;
            });
            
}