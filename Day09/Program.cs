
var testInput = File.ReadAllLines("input.txt");



var input = Enumerable.Range(0, testInput.Length).Select((i => testInput[i].Split(' '))).ToArray();

Stack<List<int>> increment = new Stack<List<int>>();
int incrementSize = 0;

int sequencePrediction = 0;
int sumSequencePredictions = 0;
foreach (var i in input)
{
    increment.Clear();
    increment.Push(Array.ConvertAll(i, int.Parse).ToList());
    
    while(true)
    {
        var usage = increment.Count == 1 ? Array.ConvertAll(i, s => int.Parse(s)) : increment.Peek().ToArray();
        
        incrementSize = usage.Length - 1;

        var incList = new List<int>();
        for (int j = 0; j < incrementSize; j++)
        {
            incList.Add(0);
        }
        
    
        for (var j = 0; j < incList.Count; j++)
        {
            incList[j] = usage[j + 1] - usage[j];
        }
        increment.Push(incList);

        if (incList.All(inc => inc == 0)) break;
    }

    bool firstAdded = false;
    

    while (true)
    { 
        var incList = increment.Pop();
        var upperIncList = increment.Peek();
        if(!firstAdded) 
        {
            // incList.Add(incList[0]);
            incList.Insert(0, incList[0]);
            firstAdded = true;
        }
        
        // upperIncList.Add(incList[^1] + upperIncList[^1]);
        upperIncList.Insert(0,upperIncList[0] -  incList[0]);

        if (increment.Count == 1)
        {
            // sequencePrediction = upperIncList[^1];
            sequencePrediction = upperIncList[0];
            break;
        }
    }

    Console.WriteLine(sequencePrediction);
    
    sumSequencePredictions += sequencePrediction;
}

Console.WriteLine("sum = " + sumSequencePredictions);