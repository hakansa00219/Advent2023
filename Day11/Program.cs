﻿using System.Text.RegularExpressions;

string[] input = File.ReadAllLines("input.txt");

string[][] space = new string[input.Length][];
for (int i = 0; i < input.Length; i++)
{
    space[i] = new string[input[i].Length];
    for (int j = 0; j < space[i].Length; j++)
    {
        space[i][j] = input[i][j].ToString();
    }
}
List<int> spaceExtensionWidthIndexes = new List<int>();
List<int> spaceExtensionHeightIndexes = new List<int>();
Dictionary<string, (int, int)> galaxies = new Dictionary<string, (int, int)>();

for (var i = 0; i < input.Length; i++)
{
    
    if (!space[i].Contains("#"))
    {
        spaceExtensionWidthIndexes.Add(i);
    }

    bool checkingHeightExt = true;
    
    for (int j = 0; j < space[i].Length; j++)
    {
        if (space[j][i] is "#")
        {
            checkingHeightExt = false;
            break;
        }
    }
    
    
    if(checkingHeightExt) spaceExtensionHeightIndexes.Add(i);
}

int expansionRateRaw = 1;
int expansionRate = expansionRateRaw - 1;

var spaceL = space.ToList();
int index = 0;
// spaceExtensionWidthIndexes.ForEach(i =>
// {
//     for (int j = 0; j < expansionRate; j++)
//     {
//         spaceL.Insert(i + index++, space[i]);
//     }
//     
// });
// index = 0;
// spaceExtensionHeightIndexes.ForEach(i =>
// {
//     for (int k = 0; k < expansionRate; k++)
//     {
//         for (var j = 0; j < space[0].Length + (spaceExtensionWidthIndexes.Count * expansionRate); j++)
//         {
//             var temp = spaceL[j].ToList();
//             temp.Insert(i + (index * expansionRate), ".");
//             spaceL[j] = temp.ToArray();
//         }
//     }
//     
//
//     index++;
// });


index = 1;
for (var i = 0; i < spaceL.Count; i++)
{
    for (int j = 0; j < spaceL[i].Length; j++)
    {
        
        if (spaceL[i][j] is "#")
        {
            spaceL[i][j] = (index++).ToString();
            galaxies.Add(spaceL[i][j], (i,j));
        }
    }
}

List<(string, string)> doneChecks = new List<(string,string)>();
double sumOfGalaxyShortestDistances = 0;
foreach (var (key, value) in galaxies)
{
    foreach (var (key2, value2) in galaxies)
    {
        if (key == key2) continue;
        if (doneChecks.Contains((key,key2)) || doneChecks.Contains((key2, key))) continue;
        
        int dist = Math.Abs(value2.Item2 - value.Item2) + Math.Abs(value2.Item1 - value.Item1);
        
        foreach (var spaceExtensionWidthIndex in spaceExtensionWidthIndexes)
        {
            if ((spaceExtensionWidthIndex > value.Item1 && spaceExtensionWidthIndex < value2.Item1) ||
                (spaceExtensionWidthIndex < value.Item1 && spaceExtensionWidthIndex > value2.Item1))
            {
                // Console.WriteLine(value + " ve " + value2 + $" icerisinde {spaceExtensionWidthIndex}. row indexinde genleşme var.");
                dist += expansionRate;
            }
        }
        foreach (var spaceExtensionHeightIndex in spaceExtensionHeightIndexes)
        {
            if ((spaceExtensionHeightIndex > value.Item2 && spaceExtensionHeightIndex < value2.Item2) ||
                (spaceExtensionHeightIndex < value.Item2 && spaceExtensionHeightIndex > value2.Item2))
            {
                // Console.WriteLine(value + " ve " + value2 + $" icerisinde {spaceExtensionHeightIndex}. height indexinde genleşme var.");
                dist += expansionRate;
            }
        }
        
        // Console.WriteLine($"{key} - {key2} | dist = " + dist);
        Console.WriteLine(key);
        sumOfGalaxyShortestDistances += dist;
        doneChecks.Add((key ,key2));
    }    
}

foreach (var s in spaceL)
{
    foreach (var c in s)
    {
        Console.Write(c);
    }
    Console.Write("\n");
}

Console.WriteLine(sumOfGalaxyShortestDistances);