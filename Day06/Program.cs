var data = File.ReadAllLines("input.txt");

//-Part1
var times = Array.ConvertAll(data[0].Split(' ').Where(s => !string.IsNullOrEmpty(s)).Skip(1).ToArray(), int.Parse);
var distances =  Array.ConvertAll(data[1].Split(' ').Where(s => !string.IsNullOrEmpty(s)).Skip(1).ToArray(), int.Parse);
//-

//-Part2
var times2 = long.Parse(string.Join("", Array.ConvertAll(times, e => e.ToString())));
var distances2 = long.Parse(string.Join("", Array.ConvertAll(distances, e => e.ToString())));
//-

long solution = 1;
for (int i = 0; i < times.Length; i++)
{
    // Part1
    // var x = Enumerable.Range(1, times[i]).Count(e => (times[i] - e) * e > distances[i]);
    // solution *= x;
}

// Part2
solution = Enumerable.Range(1, (int)times2).Count(e => (times2 - e) * e > distances2);

Console.WriteLine(solution);

// using System.Diagnostics;
//
// Stopwatch sw = new Stopwatch();
// sw.Start();
// double times2 = 7153000000;
// double distances2 = 94020000000;
// double solution = 0;
// for (double i = 1; i < times2; i++)
// {
//     if ((times2 - i) * i > distances2) solution++;
// }
// Console.WriteLine(sw.ElapsedMilliseconds);
// Console.WriteLine(solution);