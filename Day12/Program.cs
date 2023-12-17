

using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

var input = File.ReadAllLines("input.txt");

var damagedRecords = input.Select(s => s.Split(' ')[1])
    .Select(s => s.Replace(',', ' '))
    .Select(s => s.Split(' '))
    .Select(s => Array.ConvertAll(s, int.Parse)).ToArray();

var damagedRecords2 = input.Select(s => s.Split(' ')[1])
    .Select(s => s + ',' + s)
    .Select(s => s.Replace(',', ' '))
    .Select(s => s.Split(' '))
    .Select(s => Array.ConvertAll(s, int.Parse)).ToArray();

var springs = input.Select(s => s.Split(' ')[0])
    .ToArray();
var springs2 = input.Select(s => s.Split(' ')[0])
    .Select(s => s + '?' + s).ToArray();

double springsSumArrangements = 0;

//foreach spring
for (int i = 0; i < springs.Length; i++)
{
    //--------------S1---------------
    List<int> unknownIndexes = new List<int>();
    for (var j = 0; j < springs[i].Length; j++)
    {
        if(springs[i][j] is '?') unknownIndexes.Add(j);
    }
    
    var hashCount = springs[i].Count(c => c is '#');
    var damagedCount = damagedRecords[i].Sum();

    var combinationLength = damagedCount - hashCount;

    bool combinationResult = true;
    double arrangements = 0;
    
    if (combinationLength == 0 && CheckArrangements(i, default,springs,damagedRecords, false ))
    {
        arrangements++;
        Console.WriteLine(springs[i] + " spring has " + arrangements + " arrangements.");
        springsSumArrangements += arrangements;
        continue;
    }

    var combinations = Utils.GetKCombs<int>(unknownIndexes, combinationLength).ToArray();



    foreach (var combination in combinations)
    {
        if (CheckArrangements(i, combination, springs,damagedRecords,true))
        {
            arrangements++;
        }
    }
    //--------------END---------------
    //--------------S2---------------
    List<int> unknownIndexes2 = new List<int>();
    for (var j = 0; j < springs2[i].Length; j++)
    {
        if(springs2[i][j] is '?') unknownIndexes2.Add(j);
    }
    
    var hashCount2 = springs2[i].Count(c => c is '#');
    var damagedCount2 = damagedRecords2[i].Sum();

    var combinationLength2 = damagedCount2 - hashCount2;

    bool combinationResult2 = true;
    double arrangements2 = 0;
    
    if (combinationLength2 == 0 && CheckArrangements(i, default,springs2,damagedRecords2, false ))
    {
        arrangements2++;
        Console.WriteLine(springs2[i] + " spring has " + arrangements2 + " arrangements.");
        springsSumArrangements += arrangements2;
        continue;
    }

    var combinations2 = Utils.GetKCombs<int>(unknownIndexes2, combinationLength2).ToArray();



    foreach (var combination2 in combinations2)
    {
        if (CheckArrangements(i, combination2,springs2,damagedRecords2, true))
        {
            arrangements2++;
        }
    }
    //--------------END--------------

    double solution = Math.Pow(arrangements2 / arrangements, 3) * arrangements2;
    Console.WriteLine(i + "." + " spring has " + solution + " arrangements.");
    springsSumArrangements += solution;
}
Console.WriteLine("Sum of all springs arrangements: " + springsSumArrangements);


Console.ReadKey();

bool CheckArrangements(int springIndex, IEnumerable<int> combination, string[] springss,int[][] damagedRecordss, bool isMultipleCombinations)
{
    bool b;
    StringBuilder tempSpringSolution = new StringBuilder();
    tempSpringSolution.Append(springss[springIndex]);
    for (int j = 0; j < tempSpringSolution.Length; j++)
    {
        if (isMultipleCombinations)
        {
            tempSpringSolution[j] = combination.Contains(j)
                ? '#'
                : tempSpringSolution[j] is '?' ? '.' : tempSpringSolution[j];
        }
        else
        {
            tempSpringSolution[j] = tempSpringSolution[j] is '?' ? '.' : tempSpringSolution[j];
        }
        
    }

    var hashCounts = Regex.Replace(tempSpringSolution.ToString().Replace('.', ' '), @"\s+", " ")
        .Split(' ')
        .Where(s => s.Length != 0)
        .Select(s => s.Count(c => c == '#'))
        .ToArray();

    b = true;

    for (int j = 0; j < hashCounts.Length; j++)
    {
        if (hashCounts.Length != damagedRecordss[springIndex].Length || hashCounts[j] != damagedRecordss[springIndex][j])
        {
            b = false;
        }
    }
    
    return b;
}

public static class Utils
{
    public static IEnumerable<IEnumerable<T>> 
        GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
    {
        if (length == 1) return list.Select(t => new T[] { t });
        return GetKCombs(list, length - 1)
            .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0), 
                (t1, t2) => t1.Concat(new T[] { t2 }));
    }
}
