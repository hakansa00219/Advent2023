var input = File.ReadAllLines("input.txt");

var data = input.Select(s => s.ToCharArray().ToList()).ToList();

var totalLoad = 0; 

List<List<char>> reversedData = new List<List<char>>();
        
for (var i = 0; i < data[0].Count; i++)
{
    reversedData.Add(new List<char>());
    foreach (var t in data)
    {
        reversedData[i].Add(t[i]);
    }
}

Queue<int> replacableIndexes = new Queue<int>();
int dequeuedIndex = 0;
int dataCount = reversedData.Count;
for (var i = 0; i < dataCount; i++)
{
    replacableIndexes.Clear();
    for (var j = 0; j < reversedData[i].Count; j++)
    {
        if (reversedData[i][j] is 'O')
        {
            if (replacableIndexes.Count > 0)
            {
                dequeuedIndex = replacableIndexes.Dequeue();
                reversedData[i][dequeuedIndex] = 'O';
                reversedData[i][j] = '.';
                replacableIndexes.Enqueue(j);
                totalLoad += dataCount - dequeuedIndex;
            }
            else
            {
                totalLoad += dataCount - j;
            }
        }
        else if (reversedData[i][j] is '.')
        {
            replacableIndexes.Enqueue(j);
        }
        else if (reversedData[i][j] is '#')
        {
            replacableIndexes.Clear();
        }
    }
}


Console.WriteLine("Total load = " + totalLoad); 
