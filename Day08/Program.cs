
var data = File.ReadAllLines("input.txt");

var steps = data[0];

var route = data.Skip(2).ToArray();
Dictionary<string, (string Left, string Right)> routes = new Dictionary<string, (string Left, string Right)>();
List<string> endWithCharA = new List<string>();

foreach (var s in route)
{
    routes.Add(s[..3], (s[7..10],s[12..15]));
    
    if(s[2] is 'A') endWithCharA.Add(s);
}

// const string reach = "ZZZ";
// const string start = "AAA";
int stepCount = 0;
int totalSteps = 0;

string[] destinations = endWithCharA.Select(s => s[..3]).ToArray();


bool[] reaches = new bool[endWithCharA.Count];

while (true)
{
    
    for (int i = 0; i < destinations.Length; i++)
    {
        reaches[i] = CheckRoute(destinations[i],i);
    }
    totalSteps++;
    stepCount = (stepCount + 1) % steps.Length;

    if (reaches.All(b => b)) break;
}

Console.WriteLine(totalSteps);

bool CheckRoute(string destination, int destIndex)
{
    destinations[destIndex] = steps[stepCount] is 'L' ? routes[destination].Left : routes[destination].Right;
    return destinations[destIndex][2] is 'Z';
}