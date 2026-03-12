

using System.Diagnostics;

public class Racer(string racerName, int laps, int delayMS)
{
    public void StartRace()
    {
        Stopwatch timer = Stopwatch.StartNew();

        for (int i = 0; i < laps; i++)
        {
            Console.WriteLine($"{racerName} has finished {i+1}/{laps} laps");
            Thread.Sleep(delayMS);
        }
        timer.Stop();

        Console.WriteLine($"{racerName} finished all th laps in: {timer.ElapsedMilliseconds}");
    }
}