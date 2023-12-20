using System.Text;

var input = File.ReadAllText("input.txt");

var testInput = "HASH";
var splittedInput = input.Split(',');

int sum = 0;
int currentValue = 0;

foreach (var s in splittedInput)
{
    byte[] bytes = new byte[s.Length];
    bytes = Encoding.ASCII.GetBytes(s);

    currentValue = 0;
    
    foreach (var b in bytes)
    {
        currentValue += b;
        currentValue *= 17;
        currentValue %= 256;
    }

    Console.WriteLine(currentValue);

    sum += currentValue;
}

Console.WriteLine(sum);