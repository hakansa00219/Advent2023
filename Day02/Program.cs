// See https://aka.ms/new-console-template for more information

string testInput = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green\nGame 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue\nGame 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red\nGame 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red\nGame 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";
string mainInput = "Game 1: 4 red, 8 green; 8 green, 6 red; 13 red, 8 green; 2 blue, 4 red, 4 green\nGame 2: 5 blue; 1 red, 3 blue; 1 red, 7 blue, 1 green; 1 red, 8 blue; 7 blue, 1 red; 4 blue, 1 green, 1 red\nGame 3: 8 blue, 5 green, 15 red; 6 red, 6 blue, 3 green; 8 red, 2 green; 10 blue, 10 red, 6 green; 8 red, 6 blue; 15 red, 5 green, 2 blue\nGame 4: 10 green, 12 red, 14 blue; 5 green, 9 red, 7 blue; 14 blue, 12 red; 8 blue, 7 green, 11 red\nGame 5: 13 blue, 10 red, 7 green; 3 green, 8 red, 4 blue; 16 red, 5 green, 5 blue; 2 blue, 9 red, 7 green; 5 red, 14 blue, 3 green; 2 red, 11 blue, 2 green\nGame 6: 3 blue, 1 green; 10 green, 12 red, 6 blue; 3 green, 2 red, 5 blue; 2 blue, 11 green, 2 red; 1 red, 5 blue, 9 green\nGame 7: 2 blue, 10 green; 3 red, 10 blue; 3 green, 8 blue, 5 red; 8 green, 10 blue, 2 red\nGame 8: 15 red, 12 blue, 5 green; 10 red, 12 blue, 5 green; 10 red, 7 green\nGame 9: 18 blue, 14 red; 3 green, 9 blue; 1 blue, 11 red; 5 red, 7 blue, 3 green; 8 red, 4 green, 1 blue\nGame 10: 2 blue; 10 green, 4 blue, 3 red; 5 green, 4 red, 4 blue; 1 red, 3 blue, 4 green; 2 blue, 5 red, 3 green; 3 green, 2 red, 2 blue\nGame 11: 4 blue, 19 green; 19 blue, 12 green, 17 red; 11 red, 10 blue, 17 green; 9 green, 18 blue; 14 green, 9 red, 18 blue; 15 blue, 6 green, 19 red\nGame 12: 1 green, 6 blue, 2 red; 6 blue, 2 red, 8 green; 2 green, 2 red, 7 blue; 1 red, 3 blue, 6 green\nGame 13: 2 red, 11 blue, 4 green; 2 red, 7 blue; 9 green, 1 red, 12 blue; 13 blue, 8 green; 11 blue, 8 green, 1 red; 1 red, 2 blue\nGame 14: 1 green, 4 blue, 11 red; 11 green, 6 blue, 7 red; 7 green, 6 blue, 4 red; 12 blue, 10 red, 11 green\nGame 15: 1 green, 19 red, 3 blue; 11 red, 3 blue; 20 red, 4 blue\nGame 16: 3 red, 1 green, 7 blue; 3 blue, 4 red, 1 green; 6 blue, 7 red, 3 green\nGame 17: 7 blue, 4 red, 19 green; 7 green, 4 red; 8 green, 2 red, 4 blue\nGame 18: 1 red, 1 blue, 6 green; 2 red, 6 green, 1 blue; 4 green, 1 red, 1 blue\nGame 19: 4 blue, 8 green, 6 red; 2 red, 9 green, 4 blue; 9 green, 8 red, 6 blue; 3 red, 6 blue, 9 green; 8 red, 4 blue, 7 green\nGame 20: 3 blue, 7 green, 13 red; 13 blue; 12 red, 14 blue; 3 red, 6 green, 8 blue\nGame 21: 5 green, 2 red, 10 blue; 2 red, 2 green, 6 blue; 1 blue, 1 red, 7 green; 4 blue, 1 red, 2 green\nGame 22: 2 red; 1 green, 7 red; 3 red, 1 green, 1 blue; 4 red, 5 green, 3 blue; 1 blue, 2 green\nGame 23: 15 red, 1 blue, 3 green; 6 blue, 3 green, 2 red; 6 green, 4 red, 1 blue\nGame 24: 17 green; 1 red, 2 blue, 3 green; 10 blue, 1 green; 1 green; 1 red, 2 blue, 1 green\nGame 25: 2 green, 8 blue, 1 red; 1 blue, 1 red, 9 green; 1 blue, 2 green, 2 red; 3 red, 6 blue\nGame 26: 12 red, 19 green, 4 blue; 2 red, 10 blue, 15 green; 14 blue, 17 red, 3 green; 1 green, 15 red, 3 blue\nGame 27: 11 green, 1 red, 9 blue; 3 green, 10 blue; 9 green, 10 blue, 1 red; 4 green, 3 blue, 1 red; 2 blue, 5 green, 2 red; 17 blue, 2 red, 5 green\nGame 28: 10 green, 10 red, 5 blue; 5 red, 4 blue, 8 green; 3 green, 10 red, 3 blue; 2 blue, 8 green, 1 red; 6 red, 1 green, 4 blue\nGame 29: 3 blue, 11 red, 1 green; 5 blue, 3 green, 6 red; 8 red, 12 blue, 10 green; 1 blue, 4 red, 1 green\nGame 30: 10 blue, 1 red, 2 green; 1 red, 8 blue, 2 green; 4 blue, 3 green; 5 green, 1 red, 3 blue; 3 green, 14 blue\nGame 31: 3 red, 7 green, 6 blue; 11 red, 4 green, 2 blue; 1 green, 11 red, 8 blue; 6 green, 5 blue, 5 red; 4 green, 3 blue, 15 red\nGame 32: 9 green, 1 blue, 10 red; 13 red, 7 green; 12 red, 6 green, 1 blue\nGame 33: 9 green, 4 red, 6 blue; 2 red, 4 blue, 1 green; 2 blue, 11 red, 9 green\nGame 34: 8 green, 6 red; 4 blue, 3 green; 6 red, 1 blue, 9 green; 10 green, 1 red; 2 red, 2 blue, 2 green; 2 blue\nGame 35: 4 blue, 8 green, 8 red; 1 blue, 10 green; 5 green, 8 red; 4 green; 6 red, 1 blue, 6 green\nGame 36: 4 red, 10 blue, 16 green; 18 blue, 5 red, 5 green; 16 green, 11 blue, 1 red; 6 green, 10 blue; 4 red, 9 green, 17 blue; 1 red, 9 blue, 14 green\nGame 37: 1 red, 13 green, 5 blue; 2 red, 12 green, 12 blue; 5 red, 11 blue, 5 green; 9 green, 4 blue\nGame 38: 1 green, 12 blue, 1 red; 11 blue, 3 red, 1 green; 17 red, 11 blue; 8 red, 2 blue\nGame 39: 11 blue, 12 red, 1 green; 1 blue, 1 green, 4 red; 3 green, 6 blue, 3 red\nGame 40: 1 blue, 1 red; 9 green, 2 red, 2 blue; 9 green, 3 red; 8 green, 4 blue, 4 red; 3 green, 3 red\nGame 41: 7 blue, 8 red, 3 green; 4 red, 7 green, 1 blue; 5 blue, 6 red, 5 green; 4 blue, 9 red; 2 green, 9 blue, 5 red\nGame 42: 8 blue, 17 green, 7 red; 6 red, 11 green, 13 blue; 7 red, 3 blue, 14 green; 2 red, 12 blue, 2 green; 18 green, 8 red; 10 green, 5 blue\nGame 43: 5 green, 9 red, 3 blue; 3 red, 5 green; 6 green, 1 blue, 10 red; 8 blue, 1 green, 2 red\nGame 44: 1 red, 5 blue; 4 green, 6 red, 2 blue; 12 green, 8 red; 4 blue, 2 red, 9 green; 1 blue, 5 green, 3 red\nGame 45: 9 blue, 5 red, 6 green; 10 blue, 7 green, 8 red; 1 red, 1 green, 10 blue; 2 red, 1 green, 11 blue; 11 red\nGame 46: 14 blue, 8 green, 2 red; 10 green, 8 blue; 7 blue, 12 green; 14 green, 10 blue, 2 red\nGame 47: 5 blue, 7 green, 1 red; 5 blue, 5 green, 3 red; 2 red, 8 green, 3 blue; 2 red, 2 green\nGame 48: 2 red, 2 blue, 1 green; 1 green, 1 blue, 3 red; 1 blue, 1 red; 3 green, 8 blue\nGame 49: 7 red, 2 blue, 8 green; 8 red, 4 green; 2 blue, 4 red, 8 green\nGame 50: 9 red, 4 blue, 10 green; 11 red, 7 green, 4 blue; 4 green, 16 red, 2 blue; 13 red, 9 blue, 3 green; 1 red, 6 blue\nGame 51: 8 blue, 2 red, 3 green; 2 blue, 2 red; 4 blue, 1 green; 1 red, 2 blue, 2 green; 5 green, 6 blue, 1 red\nGame 52: 12 blue, 8 red; 11 green, 9 red, 11 blue; 8 blue, 5 green, 8 red; 3 red, 11 blue, 11 green; 12 blue, 6 green, 5 red; 10 red, 8 green\nGame 53: 9 green, 6 red, 3 blue; 4 blue, 5 green, 3 red; 11 green, 5 blue, 2 red; 4 red, 9 green\nGame 54: 13 blue, 8 green; 15 blue, 3 red, 7 green; 8 green, 1 blue; 8 blue, 3 red, 6 green; 3 red, 1 green, 12 blue; 9 green, 3 red, 2 blue\nGame 55: 2 red, 1 blue, 2 green; 4 blue, 3 green, 1 red; 4 red, 7 green, 4 blue; 7 green, 3 red, 1 blue; 2 blue, 4 green, 1 red; 5 blue, 1 red, 4 green\nGame 56: 14 green, 1 blue, 4 red; 3 red, 1 blue; 10 red, 8 blue; 8 red, 7 blue, 3 green; 3 green, 12 blue, 4 red; 7 red, 2 green\nGame 57: 7 blue, 8 green, 6 red; 7 green, 5 blue, 3 red; 2 red, 8 blue, 9 green\nGame 58: 7 green, 8 red, 3 blue; 7 red, 5 blue, 9 green; 4 blue, 3 red, 9 green; 1 green; 5 green, 2 blue; 5 blue, 7 green, 2 red\nGame 59: 2 blue, 10 green; 8 blue, 10 red, 1 green; 1 red, 10 blue, 7 green; 2 red, 7 blue, 1 green; 5 green, 3 blue\nGame 60: 1 green, 2 blue; 5 red, 2 green, 2 blue; 2 green, 3 red\nGame 61: 3 green, 2 red; 10 green, 7 red, 2 blue; 8 green, 2 blue; 5 green, 3 red, 1 blue; 12 green, 1 red; 1 blue, 13 green, 6 red\nGame 62: 11 green, 2 red; 3 blue, 3 red; 2 blue, 1 red, 10 green; 11 green, 3 blue\nGame 63: 7 blue; 7 red, 1 green, 8 blue; 5 red, 14 blue, 1 green\nGame 64: 2 green, 12 blue, 1 red; 18 blue, 10 red; 9 blue, 2 green, 13 red; 1 red, 1 green, 15 blue\nGame 65: 6 blue, 8 red, 8 green; 2 green, 9 red, 9 blue; 3 green, 9 red, 1 blue; 10 red, 4 blue, 2 green; 7 blue, 5 red, 5 green\nGame 66: 14 red, 3 green, 9 blue; 3 blue, 7 green, 12 red; 5 red, 8 green, 1 blue; 12 red, 5 green, 4 blue; 5 green, 14 blue\nGame 67: 1 blue, 9 red, 7 green; 12 red, 9 green, 1 blue; 13 red, 4 green, 2 blue; 1 red, 1 blue, 5 green; 10 red, 2 blue\nGame 68: 12 green, 2 red; 1 red, 4 green, 7 blue; 3 red, 4 blue, 14 green; 6 blue, 6 green; 7 blue, 4 green, 3 red\nGame 69: 2 green, 17 blue, 9 red; 6 blue, 3 green, 4 red; 11 blue, 4 red, 6 green\nGame 70: 11 blue, 10 red, 12 green; 9 red, 10 blue, 5 green; 2 red, 3 green, 9 blue; 5 green, 6 blue, 6 red; 12 green, 8 red, 10 blue\nGame 71: 7 blue, 3 red; 1 green, 11 blue, 1 red; 1 red, 5 blue, 1 green\nGame 72: 9 red, 7 blue; 1 green, 6 blue; 15 red, 6 blue; 5 red, 4 blue; 4 blue, 4 red, 1 green\nGame 73: 10 green, 4 red; 1 green, 5 red; 3 red, 1 green; 1 blue, 9 green, 6 red\nGame 74: 6 red, 3 blue, 8 green; 5 green, 9 red, 1 blue; 1 blue, 1 green, 2 red\nGame 75: 2 blue, 3 green; 3 blue, 7 green, 1 red; 6 green, 1 red; 5 green, 1 blue; 7 green, 3 blue\nGame 76: 4 red, 2 blue; 1 green, 7 red; 2 blue, 3 red; 1 green, 1 red, 1 blue; 4 red, 1 green\nGame 77: 18 green, 19 red, 11 blue; 1 blue, 18 red; 5 blue, 10 red, 16 green\nGame 78: 3 red, 8 blue, 1 green; 2 red, 3 blue; 1 green, 6 red, 12 blue\nGame 79: 5 red, 4 green, 9 blue; 3 blue; 4 red, 5 green, 2 blue; 7 blue, 5 green, 8 red; 5 red, 6 green; 7 blue, 5 green\nGame 80: 8 green, 11 red, 3 blue; 15 red, 4 blue, 8 green; 6 green, 14 red\nGame 81: 11 green, 5 red; 7 green, 14 blue, 4 red; 7 red, 8 blue, 2 green; 10 red, 3 green, 18 blue; 3 red, 1 green\nGame 82: 2 blue, 5 red; 3 green, 5 red, 7 blue; 3 green, 4 blue, 2 red; 10 blue, 2 green, 2 red; 8 blue, 2 red; 3 green, 3 red, 7 blue\nGame 83: 7 red, 12 green, 1 blue; 5 blue, 17 green, 5 red; 9 red, 3 blue; 2 blue, 1 red, 20 green; 5 red, 6 blue; 2 blue, 3 red, 11 green\nGame 84: 1 blue, 7 red, 6 green; 6 red, 8 green, 10 blue; 8 green, 1 blue, 6 red; 8 red, 4 blue, 6 green; 3 red, 12 blue, 8 green; 3 red, 2 blue, 7 green\nGame 85: 1 blue, 1 green, 8 red; 9 blue, 9 green, 2 red; 10 green, 12 red, 7 blue; 7 green, 2 blue, 7 red; 7 red, 3 green; 11 red, 9 blue, 5 green\nGame 86: 4 blue, 8 red; 4 red, 3 green; 7 blue, 12 red, 4 green; 4 green, 8 blue, 3 red\nGame 87: 6 blue, 19 green, 5 red; 20 green, 5 red, 5 blue; 8 red, 3 blue, 9 green; 11 blue, 7 green, 7 red; 17 green, 11 blue\nGame 88: 1 green, 2 red, 5 blue; 2 blue, 11 green; 3 red, 3 blue, 6 green; 4 blue, 2 green, 1 red; 8 green, 4 blue\nGame 89: 19 red, 15 green, 10 blue; 17 green, 1 red, 4 blue; 13 green, 10 blue, 15 red\nGame 90: 3 blue, 1 red; 4 blue, 1 red, 1 green; 4 green, 3 red; 4 red, 4 green, 5 blue; 2 green, 3 blue; 4 red, 2 green, 4 blue\nGame 91: 8 red, 4 blue, 16 green; 17 green, 5 blue, 4 red; 10 green, 6 red; 11 red, 7 blue; 14 blue, 4 red\nGame 92: 1 green, 3 red, 1 blue; 2 blue, 2 green, 5 red; 2 blue, 8 red; 1 blue, 2 green, 14 red; 3 red; 1 blue, 9 red\nGame 93: 11 blue, 7 red, 8 green; 8 red, 6 blue, 5 green; 4 blue, 4 green, 6 red\nGame 94: 2 green, 1 blue; 5 green, 5 red, 4 blue; 7 green, 2 blue; 5 red, 1 green, 3 blue; 2 blue, 1 green, 5 red; 1 red, 3 blue, 5 green\nGame 95: 3 red; 7 green, 4 red, 7 blue; 5 red, 5 blue\nGame 96: 3 red, 5 blue, 1 green; 3 blue, 14 red, 2 green; 7 blue, 3 red, 2 green; 15 red, 5 blue\nGame 97: 17 red, 8 green, 6 blue; 8 blue, 9 green; 4 green, 18 red\nGame 98: 9 blue, 2 green; 4 red, 6 blue, 3 green; 2 red; 14 red, 12 blue\nGame 99: 4 red, 3 green, 3 blue; 2 red, 2 blue; 7 green, 3 blue; 5 red, 2 green\nGame 100: 5 green, 7 red, 4 blue; 11 green, 9 red, 8 blue; 2 blue, 12 green";
const byte maxRedCubes = 12;
const byte maxGreenCubes = 13;
const byte maxBlueCubes = 14;

const char blue = 'b';
const string red = "red";
const char green = 'g';
const string cleanStr = ": ";

// int sumPossibleIDs = 0;
int sumPowerOfGames = 0;


var gameSeperatedList = mainInput.Split('\n');

List<string> separatedBags = new List<string>();
string separatedGame = "";
string[] separatedCubes = new string[3];
string separatedCube = "";
int charIndex = 0;
byte cubeValue = 0;
// bool isPossible = true;

int gameMaxBlueValue = 0;
int gameMaxGreenValue = 0;
int gameMaxRedValue = 0;

for (var i = 0; i < gameSeperatedList.Length; i++)
{
    separatedGame = gameSeperatedList[i];
    separatedGame = separatedGame[(separatedGame.IndexOf(cleanStr, StringComparison.Ordinal) + cleanStr.Length)..];
    separatedGame = separatedGame.Replace("; ", ";");
    
    separatedBags = separatedGame.Split(';').ToList();

    // isPossible = true;
    
    gameMaxBlueValue = 0;
    gameMaxGreenValue = 0;
    gameMaxRedValue = 0;

    
    foreach (var separatedBag in separatedBags)
    {
        //8 green,6 blue,20 red
        separatedCubes = separatedBag.Split(',');
        //8 green
        //6 blue
        //20 red
        separatedCube = separatedCubes.FirstOrDefault(s => s.Contains(blue));
        if (!string.IsNullOrEmpty(separatedCube))
        {
            cubeValue = byte.Parse(separatedCube[..^5]);

            if (cubeValue > gameMaxBlueValue)
            {
                // Console.WriteLine($"{cubeValue} is bigger than {maxBlueCubes} - BLUE. So game {(i+1)} is impossible");
                // isPossible = false;
                gameMaxBlueValue = cubeValue;
                // break;
            }
        }
        
        separatedCube = separatedCubes.FirstOrDefault(s => s.Contains(green));
        if (!string.IsNullOrEmpty(separatedCube))
        {
            cubeValue = byte.Parse(separatedCube[..^6]);

            if (cubeValue > gameMaxGreenValue)
            {
                // Console.WriteLine($"{cubeValue} is bigger than {maxGreenCubes} - GREEN. So game {(i+1)} is impossible");
                // isPossible = false;
                // break;
                gameMaxGreenValue = cubeValue;
            }
        }

        separatedCube = separatedCubes.FirstOrDefault(s => s.Contains(red));
        if (!string.IsNullOrEmpty(separatedCube))
        {
            cubeValue = byte.Parse(separatedCube[..^4]);

            if (cubeValue > gameMaxRedValue)
            {
                // Console.WriteLine($"{cubeValue} is bigger than {maxRedCubes} - RED. So game {(i+1)} is impossible");
                // isPossible = false;
                // break;
                gameMaxRedValue = cubeValue;
            }
        }


    }
    
    // if(isPossible) sumPossibleIDs += i + 1;
    sumPowerOfGames += gameMaxRedValue * gameMaxBlueValue * gameMaxGreenValue;
}

Console.WriteLine(sumPowerOfGames);
