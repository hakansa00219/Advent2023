

using System.Text;

var input = File.ReadAllLines("test.txt");

char[][] energizedTileset = new char[input.Length][];

for (var i = 0; i < energizedTileset.Length; i++)
{
    energizedTileset[i] = new char[input[0].Length];
    for (var j = 0; j < energizedTileset[i].Length; j++)
    {
        energizedTileset[i][j] = '.';
    }

    
}

List<MoveDetails> movesCache = new List<MoveDetails>();
Queue<MoveDetails> moves = new Queue<MoveDetails>();

(int i,int j) position = (0,0);
energizedTileset[0][0] = '#';
MoveDetails currentMove = new MoveDetails() { headingDirection = Move.Right, position = position };
moves.Enqueue(currentMove);
// movesCache.Add(currentMove);

while (moves.Count > 0)
{
    var move = moves.Dequeue();
    var currentPosition = move.position;
    var headingDirection = move.headingDirection;
    
    if (movesCache.Contains(move) )
    {
        continue;
    }
    
    movesCache.Add(move);
    
    while (true)
    {
        
        var encounter = MoveConversion(currentPosition, headingDirection);
        
        if (encounter.Item1 == -1 || encounter.Item2 == -1 || encounter.Item1 >= input.Length ||
            encounter.Item2 >= input[0].Length)
            break;
        
        var nextDestination = input[encounter.Item1][encounter.Item2];
        var nextMove = NextMove(headingDirection, nextDestination);
        
        energizedTileset[encounter.Item1][encounter.Item2] = '#';
        
        if (nextMove is Move.RightLeft)
        {
            MoveDetails rightMove = new MoveDetails()
                { headingDirection = Move.Right, position = encounter};
            MoveDetails leftMove = new MoveDetails()
                { headingDirection = Move.Left, position = encounter};

            if (moves.FirstOrDefault(m => m.position == rightMove.position && m.headingDirection == rightMove.headingDirection) == null)
            {
                moves.Enqueue(rightMove);
            }
            if (moves.FirstOrDefault(m => m.position == leftMove.position && m.headingDirection == leftMove.headingDirection) == null)
            {
                moves.Enqueue(leftMove);
            }
            break;
        }
        if (nextMove is Move.UpDown)
        {
            MoveDetails upMove = new MoveDetails()
                { headingDirection = Move.Up, position = encounter};
            MoveDetails downMove = new MoveDetails()
                { headingDirection = Move.Down, position = encounter};
            if (moves.FirstOrDefault(m => m.position == upMove.position && m.headingDirection == upMove.headingDirection) == null)
            {
                moves.Enqueue(upMove);
            }
            if (moves.FirstOrDefault(m => m.position == downMove.position && m.headingDirection == downMove.headingDirection) == null)
            {
                moves.Enqueue(downMove);
            }
            break;
        }
        
        headingDirection = nextMove;
        currentPosition = encounter;
        
    }
}

foreach (var e in energizedTileset)
{
    foreach (var c in e)
    {
        Console.Write(c);
    }
    Console.Write('\n');
}


Move NextMove(Move headingDirection, char encounter)
{
    if (encounter is '.') return headingDirection;
    switch (headingDirection)
    {
        case Move.Right:
            switch (encounter)
            {
                case '-': return headingDirection;
                case '/': return Move.Up;
                case '\\': return Move.Down;
                case '|': return Move.UpDown;
            }

            break;
        case Move.Left:
            switch (encounter)
            {
                case '-': return headingDirection;
                case '/': return Move.Down;
                case '\\': return Move.Up;
                case '|': return Move.UpDown;
            }

            break;
        case Move.Down:
            switch (encounter)
            {
                case '-': return Move.RightLeft;
                case '/': return Move.Left;
                case '\\': return Move.Right;
                case '|': return headingDirection;
            }

            break;
        case Move.Up:
            switch (encounter)
            {
                case '-': return Move.RightLeft;
                case '/': return Move.Right;
                case '\\': return Move.Left;
                case '|': return headingDirection;
            }

            break;
    }

    return Move.Unknown;
}

(int, int) MoveConversion((int i, int j) currentPosition, Move headingDirection)
{
    switch (headingDirection)
    {
        case Move.Down: return (currentPosition.i + 1, currentPosition.j);
        case Move.Up: return (currentPosition.i - 1, currentPosition.j);
        case Move.Left: return (currentPosition.i, currentPosition.j - 1);
        case Move.Right: return (currentPosition.i, currentPosition.j + 1);
    }

    return (-1, -1);
}

enum Move {Left, Right, Up, Down, UpDown, RightLeft, Unknown}

class MoveDetails
{
    public (int, int) position;
    public Move headingDirection;
}