const char verticalPipe = '|';
const char horizontalPipe = '-';
const char NEPipe = 'L';
const char NWPipe = 'J';
const char SWPipe = '7';
const char SEPipe = 'F';
const char ground = '.';
const char start = 'S';
(int i, int j) startPos = (0,0);

var input = File.ReadAllLines("input.txt");

char[][] loopTable = new char[input.Length][];
char[][] loopP2Table = new char [input.Length][];
string[][] loopsDistanceTable = new string[input.Length][];

for (var i = 0; i < input.Length; i++)
{
    loopTable[i] = new char[input[0].Length];
    loopP2Table[i] = new char[input[0].Length];
    loopsDistanceTable[i] = new string[input[0].Length];
    for (var j = 0; j < input[i].Length; j++)
    {
        loopTable[i][j] = input[i][j];
        
        loopsDistanceTable[i][j] = input[i][j].ToString();

        if (loopTable[i][j] == start)
        {
            startPos = (i, j);
            loopsDistanceTable[i][j] = "0";
        }
    }
}

int loopTableWidth = loopTable[0].Length;
int loopTableHeight = loopTable.GetLength(0);
int distanceCounter = 1;
List<(int, int)> lastCheckedElements = new List<(int, int)>();
List<(int, int)> checkingElements = new List<(int, int)>() { (startPos.i, startPos.j) };
List<(int, int)> tempCheckingElements = new List<(int, int)>();

CheckingLoop();


int exclCount = 0;
int insideCount = 0;

for (int i = 0; i < loopP2Table.GetLength(0); i++)
{
    for (int j = 0; j < loopP2Table[i].Length; j++)
    {
        loopP2Table[i][j] = (input[i][j] is verticalPipe or NEPipe or NWPipe) && lastCheckedElements.Contains((i,j)) ? '!' : input[i][j];
        exclCount = 0;
        for (var k = 0; k < loopP2Table[i].Length; k++)
        {
            if (loopP2Table[i][j] is '!' or 'S') continue;
            if (loopP2Table[i][k] is not '!') continue;

            if (k < j && !lastCheckedElements.Contains((i,j)))
            {
                exclCount++;
            }
        }

        if (exclCount % 2 is 1)
        {
            Console.WriteLine((i,j));
            loopsDistanceTable[i][j] = "I";
            insideCount++;
        }
        
        
    }
}

for (int i = 0; i < loopsDistanceTable.GetLength(0); i++)
{
    for (int j = 0; j < loopsDistanceTable[i].Length; j++)
    {
        Console.Write(loopsDistanceTable[i][j]);
    }
    Console.Write("\n");
}
Console.Write("\n");

// Console.WriteLine(loopsDistanceTable[tempCheckingElements[0].Item1,tempCheckingElements[0].Item2]);
Console.WriteLine(insideCount);
void CheckingLoop()
{
    while (checkingElements.Count > 0)
    {
        tempCheckingElements.Clear();
        tempCheckingElements.AddRange(checkingElements);
        checkingElements.Clear();
        
        foreach ((int xIndex,int yIndex) in tempCheckingElements)
        {
            //Checking right
            if (yIndex + 1 < loopTableWidth && GetCondition(loopTable[xIndex][yIndex], loopTable[xIndex][yIndex + 1], Direction.East))
            {
                CheckingNeighbour(xIndex,
                    yIndex + 1,
                    loopTable[xIndex][yIndex + 1] == horizontalPipe ||
                    loopTable[xIndex][yIndex + 1] == NWPipe ||
                    loopTable[xIndex][yIndex + 1] == SWPipe);
            }
            //Checking left
            if (yIndex - 1 >= 0 && GetCondition(loopTable[xIndex][yIndex], loopTable[xIndex][yIndex - 1], Direction.West))
            {
                CheckingNeighbour(xIndex,
                    yIndex - 1,
                    loopTable[xIndex][yIndex - 1] == horizontalPipe ||
                    loopTable[xIndex][yIndex - 1] == NEPipe ||
                    loopTable[xIndex][yIndex - 1] == SEPipe);
            }
            //Checking up
            if (xIndex - 1 >= 0 && GetCondition(loopTable[xIndex][yIndex], loopTable[xIndex - 1][yIndex], Direction.North))
            {
                CheckingNeighbour(xIndex - 1,
                    yIndex,
                    loopTable[xIndex - 1][yIndex] == verticalPipe ||
                    loopTable[xIndex - 1][yIndex] == SWPipe ||
                    loopTable[xIndex - 1][yIndex] == SEPipe);
            }
            //Checking down
            if (xIndex + 1 < loopTableHeight && GetCondition(loopTable[xIndex][yIndex], loopTable[xIndex + 1][yIndex], Direction.South))
            {
                CheckingNeighbour(xIndex + 1,
                    yIndex,
                    loopTable[xIndex + 1][yIndex] == verticalPipe ||
                    loopTable[xIndex + 1][yIndex] == NEPipe ||
                    loopTable[xIndex + 1][yIndex] == NWPipe);
            }
            
        }
        distanceCounter++;
        
    }
    

    
}

void CheckingNeighbour(int xIndex, int yIndex, bool pipeCondition)
{
    if (pipeCondition)
    {
        if (lastCheckedElements.Contains((xIndex, yIndex)))
        {
            return;
        }
            
        if (!checkingElements.Contains((xIndex, yIndex)))
        {
            checkingElements.Add((xIndex,yIndex));
        }

        // loopsDistanceTable[xIndex][yIndex] = distanceCounter.ToString();
            
        lastCheckedElements.Add((xIndex,yIndex));
    }
}

bool GetCondition(char ownChar, char neighbourChar, Direction direction)
{
    if (ownChar is start)
    {
        return true;
    }
    
    switch (direction)
    {
        case Direction.East:
            return ownChar is horizontalPipe or SEPipe or NEPipe && neighbourChar is horizontalPipe or SWPipe or NWPipe;
        case Direction.West:
            return ownChar is horizontalPipe or SWPipe or NWPipe && neighbourChar is horizontalPipe or SEPipe or NEPipe;
        case Direction.North:
            return ownChar is verticalPipe or NEPipe or NWPipe && neighbourChar is verticalPipe or SWPipe or SEPipe;
        case Direction.South:
            return ownChar is verticalPipe or SWPipe or SEPipe && neighbourChar is verticalPipe or NEPipe or NWPipe;
    }

    return false;
}

enum Direction
{
    East,
    West,
    North,
    South
};






