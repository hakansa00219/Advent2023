var data = File.ReadAllLines("input.txt");

var seeds = data[0].Substring(data[0].IndexOf(": ", StringComparison.Ordinal) + 2);
IEnumerable<string>[] enumerables = new []
{
    data.SkipWhile(s => !s.Contains("seed-")).TakeWhile(s => s != string.Empty).Skip(1),
    data.SkipWhile(s => !s.Contains("soil-")).TakeWhile(s => s != string.Empty).Skip(1),
    data.SkipWhile(s => !s.Contains("fertilizer-")).TakeWhile(s => s != string.Empty).Skip(1),
    data.SkipWhile(s => !s.Contains("water-")).TakeWhile(s => s != string.Empty).Skip(1),
    data.SkipWhile(s => !s.Contains("light-")).TakeWhile(s => s != string.Empty).Skip(1),
    data.SkipWhile(s => !s.Contains("temperature-")).TakeWhile(s => s != string.Empty).Skip(1),
    data.SkipWhile(s => !s.Contains("humidity-")).TakeWhile(s => s != string.Empty).Skip(1)
};
//Part 2
List<long> allSeeds = new List<long>();
var seedsL = Array.ConvertAll(seeds.Split(' '), long.Parse);
for (int i = 0; i < seedsL.Length / 2; i++)
{
    var aa = CreateRange(seedsL[i * 2], (int)seedsL[i * 2 + 1]);
    
    allSeeds.AddRange(aa);
}

Console.WriteLine(allSeeds.Count);
//Part 2 ends


long tempSolution = 0;
List<long> destinations = new List<long>();
//Part 1 => // foreach (var seed in seeds.Split(' '))
foreach(var seed in allSeeds)
{
    int index = 0;
    destinations.Add(FindDestination(seed.ToString(), index, tempSolution, 0));
    
}
Console.WriteLine(destinations.Min());


long FindDestination(string seed, int index, long seedSolution, long calc = 0)
{
    
    var seedI = calc == 0 ? long.Parse(seed) : calc;
    var y = enumerables[index];
    var x = y.FirstOrDefault(s =>
    {
        long c = long.Parse(s.Split(' ')[1]);
        long d = long.Parse(s.Split(' ')[2]);
        bool a = seedI >= c;
        bool b = seedI <= c + d;
        return a && b;
    });

    if (string.IsNullOrEmpty(x))
    {
        calc = seedI;
    }
    else
    {
        var foundLine = Array.ConvertAll(x.Split(' '), long.Parse);
    
        calc =  foundLine[0] + (seedI - foundLine[1]);
    }
    if (index == enumerables.Length - 1)
    {
        seedSolution = seedSolution > calc ? seedSolution : calc;
        return seedSolution;
    }

    index++;
    return FindDestination(seed, index, seedSolution, calc);
}
IEnumerable<long> CreateRange(long start, long count)
{
    var limit = start + count;

    while (start < limit)
    {
        yield return start;
        start++;
    }
}