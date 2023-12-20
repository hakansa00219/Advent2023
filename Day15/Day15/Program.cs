using System.Text;

var input = File.ReadAllText("input.txt");

var testInput = "HASH";
var splittedInput = input.Split(',');

Dictionary<byte, List<BoxData>> boxes = new Dictionary<byte, List<BoxData>>(); 

int sum = 0;
int currentValue = 0;


foreach (var s in splittedInput)
{
    var label = string.Concat(s.TakeWhile(c => c is not ('=' or '-')).TakeWhile(char.IsLetter));
    
    var operation = s.SkipWhile(char.IsLetter).First();
    int lens = -1;
    if (operation is '=')
    {
        lens = int.Parse(string.Concat(s.SkipWhile(char.IsLetter).Skip(1)));
    }
    byte[] bytes = new byte[label.Count()];
    bytes = Encoding.ASCII.GetBytes(label);

    currentValue = 0;
    
    foreach (var b in bytes)
    {
        currentValue += b;
        currentValue *= 17;
        currentValue %= 256;
    }

    byte boxValue = Convert.ToByte(currentValue);
    BoxData boxData = new BoxData() { s = label, v = lens };
    if (operation == '=')
    {
        
        if (!boxes.ContainsKey(boxValue))
        {
            boxes.Add(boxValue, new List<BoxData>());
            boxes[boxValue].Add(boxData);
        }
        else
        {
            var foundData = boxes[boxValue].FirstOrDefault(box => box.s == boxData.s);

            if (foundData is null)
            {
                boxes[boxValue].Add(boxData);
            }
            else
            {
                foundData.v = lens;
            }
        }
    }
    else
    {
        if(!boxes.TryGetValue(boxValue, out var value)) continue;

        var foundData = value.FirstOrDefault(box => box.s == boxData.s);

        if (foundData is null) continue;
        
        value.Remove(foundData);
        
        if (!value.Any())
        {
            boxes.Remove(boxValue);
        }
    }
}
foreach (var (key, value) in boxes)
{
    foreach (var boxData in value)
    {
        int total = (key + 1) * (value.FindIndex(m => m.s == boxData.s) + 1) * boxData.v;
        sum += total;
        Console.WriteLine($"- {boxData.s}: {key + 1} * {value.FindIndex(m => m.s == boxData.s) + 1} * {boxData.v} = {total}");
    }
}

Console.WriteLine(sum);
class BoxData
{
    public string s;
    public int v;
}