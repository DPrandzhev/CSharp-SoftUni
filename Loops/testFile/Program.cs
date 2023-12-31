﻿private static int frequency = 10000;
private static int duration = 100;
Console.WriteLine("Use keyboard arrows to adjust frequency and duration");
do
{
    while (!Console.KeyAvailable)
    {
        Console.Beep(frequency, duration);
    }

    var key = Console.ReadKey(true);

    switch (key.Key)
    {
        case ConsoleKey.UpArrow:
            frequency += 100;
            frequency = Math.Min(frequency, 15000);
            break;
        case ConsoleKey.DownArrow:
            frequency -= 100;
            frequency = Math.Max(frequency, 1000);
            break;
        case ConsoleKey.RightArrow:
            duration += 100;
            duration = Math.Min(duration, 1000);
            break;
        case ConsoleKey.LeftArrow:
            duration -= 100;
            duration = Math.Max(duration, 100);
            break;
    }
} while (true);