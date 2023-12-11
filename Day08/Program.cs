
var data = File.ReadAllLines("input.txt");

var steps = data[0];

var route = data.Skip(2).ToArray();
Dictionary<string, (string Left, string Right)> routes = new Dictionary<string, (string Left, string Right)>();

foreach (var s in route)
{
    routes.Add(s[..3], (s[7..10],s[12..15]));
}

const string reach = "ZZZ";
const string start = "AAA";
int stepCount = 0;
int totalSteps = 0;

string dest = start;

while (true)
{
    if (CheckRoute(dest))
    {
        break;
    }
}


Console.WriteLine(totalSteps);

bool CheckRoute(string destination)
{
    dest = steps[stepCount] is 'L' ? routes[destination].Left : routes[destination].Right;
    stepCount = (stepCount + 1) % steps.Length;
    totalSteps++;

    if (dest is reach)
    {
        return true;
    }

    return false;
}

