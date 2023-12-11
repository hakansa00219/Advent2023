
using System.Text;

var data = File.ReadAllLines("input.txt");

Dictionary<char, string> highCardTables = new Dictionary<char, string>()
{
    {'J',"00"},{'2',"01"},{'3',"02"},{'4',"03"},{'5',"04"},{'6',"05"},{'7',"06"},{'8',"07"},{'9',"08"},{'T',"09"},{'Q',"10"},{'K',"11"},{'A',"12"}
};
var orderedValues = data.OrderBy(s => CheckHands(s.Split(' ')[0]));

int idx = 1;
int sum = 0;
foreach (var orderedValue in orderedValues)
{
    sum += int.Parse(orderedValue.Split(' ')[1]) * idx;
    idx++;
}

Console.WriteLine(sum);    




string CheckHands(string hand)
{
    Dictionary<char,int> handDuplicates = new Dictionary<char, int>();
    StringBuilder highCardValues = new StringBuilder();

    int jokerCount = 0;
    foreach (var c in hand)
    {
        if (c == 'J')
        {
            jokerCount++;
            highCardValues.Append(highCardTables[c]);
            continue;
        }
        
        if (handDuplicates.ContainsKey(c))
            handDuplicates[c]++;
        else
            handDuplicates.Add(c,1);
        
        highCardValues.Append(highCardTables[c]);
    }

    if (handDuplicates.Count is 0)
        handDuplicates.Add('J',5);
    else
        handDuplicates[handDuplicates.MaxBy(v => v.Value).Key] += jokerCount;
    
    
    
    
    StringBuilder realValue = new StringBuilder();
    if      (handDuplicates.Count is 1 && handDuplicates.Any(c => c.Value == 5)) realValue.Append((int)Hand.FiveOfAKind);
    else if (handDuplicates.Count == 2 && handDuplicates.Any(c => c.Value == 4)) realValue.Append((int)Hand.FourOfAKind);
    else if (handDuplicates.Count == 2 && handDuplicates.Any(c => c.Value == 3)) realValue.Append((int)Hand.FullHouse);
    else if (handDuplicates.Count == 3 && handDuplicates.Any(c => c.Value == 3)) realValue.Append((int)Hand.ThreeOfAKind);
    else if (handDuplicates.Count == 3 && handDuplicates.Any(c => c.Value == 2)) realValue.Append((int)Hand.TwoPair);
    else if (handDuplicates.Count == 4) realValue.Append((int)Hand.OnePair);
    else if (handDuplicates.Count == 5) realValue.Append((int)Hand.HighCard);

    realValue.Append(highCardValues);

    return realValue.ToString();
}


enum Hand
{
    FiveOfAKind  = 7,
    FourOfAKind  = 6,
    FullHouse    = 5,
    ThreeOfAKind = 4,
    TwoPair      = 3,
    OnePair      = 2,
    HighCard     = 1
}