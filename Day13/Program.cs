
var data = File.ReadAllLines("input.txt").ToList();

data.Add("");

List<string> patterns = new List<string>();

int rowCount = 0;
int columnCount = 0;
int patternsIndex = 1;
foreach (var s in data)
{
    
    if (!string.IsNullOrEmpty(s))
    {
        patterns.Add(s);
        continue;
    }
    Stack<string> patternStack = new Stack<string>();
    int mirroredCount = 1;
    bool foundMirrored = false;
    foreach (var pattern in patterns)
    {
        if (patternStack.Count == 0)
        {
            patternStack.Push(pattern);
        }
        else
        {
            if (patternStack.Peek() == pattern)
            {
                patternStack.Pop();
                mirroredCount++;
                foundMirrored = true;
            }
            else
            {
                if (foundMirrored)
                {
                    if (patterns.Last() == pattern || patterns.First() == patternStack.Peek())
                    {
                        foundMirrored = false;
                        patternStack.Clear();
                        mirroredCount = patterns.IndexOf(pattern);
                        break;
                    }
                    else
                    {
                        foundMirrored = false;
                        patternStack.Push(pattern);
                        mirroredCount = patterns.IndexOf(pattern);
                    }
                   
                    
                }

                patternStack.Push(pattern);
            }
        }
    }

    patternStack.Clear();
    
    if (foundMirrored)
    {
        rowCount += mirroredCount;
    }
    Console.WriteLine($"{patternsIndex}. pattern row count = {mirroredCount}");
    List<string> reversedPatterns = new List<string>();
        
    foreach (var t in patterns[0])
    {
        reversedPatterns.Add("");
    }
        
    for (var i = 0; i < patterns[0].Length; i++)
    {
        for (int j = 0; j < patterns.Count; j++)
        {
            reversedPatterns[i] += patterns[j][i];
        }
    }
    mirroredCount = 1;
    foreach (var reverseP in reversedPatterns)
    {
        if (patternStack.Count == 0)
        {
            patternStack.Push(reverseP);
        }
        else
        {
            if (patternStack.Peek() == reverseP)
            {
                patternStack.Pop();
                mirroredCount++;
                foundMirrored = true;
            }
            else
            {
                if (foundMirrored)
                {
                    foundMirrored = false;
                    patternStack.Clear();
                    mirroredCount = reversedPatterns.IndexOf(reverseP);
                    break;
                } 
                else
                {
                    foundMirrored = false;
                    patternStack.Push(reverseP);
                    mirroredCount = reversedPatterns.IndexOf(reverseP);
                }

                patternStack.Push(reverseP);
            }
        }
    }
    
    reversedPatterns.Clear();
    
    if (foundMirrored)
    {
        
        columnCount += mirroredCount;
    }
    Console.WriteLine($"{patternsIndex}. pattern column count = {mirroredCount}");
    patternsIndex++;
    patterns.Clear();
}

Console.WriteLine("Column sum = " + columnCount);
Console.WriteLine("Row sum = " + rowCount);

Console.WriteLine(columnCount + rowCount * 100);