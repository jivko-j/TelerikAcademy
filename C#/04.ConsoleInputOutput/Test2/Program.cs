using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

/*Implement the "Falling Rocks" game in the text console.
* A small dwarf stays at the bottom of the screen and can move left and right (by the arrows keys).
* A number of rocks of different sizes and forms constantly fall down and you need to avoid a crash.
* Rocks are the symbols ^, @, *, &, +, %, $, #, !, ., ;, - distributed with appropriate density.
* The dwarf is (O). Ensure a constant game speed by Thread.Sleep(150).
* Implement collision detection and scoring system.
*/

struct Rock
{
    public int x;
    public int y;
    public char c;
    public ConsoleColor color;
}
struct Dwarf
{
    public int myX;
    public int myY;
    public string str;
    public ConsoleColor dcolor;
}

class FallingRocks
{
    static void PrintPosition(int x, int y, char c, ConsoleColor color = ConsoleColor.Green)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = color;
        Console.Write(c);
    }

    static void PrintStringPosition(int x, int y, string str, ConsoleColor dcolor = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = dcolor;
        Console.Write(str);
    }
    static void PrintDwarf(int x, int y, string str, ConsoleColor dcolor = ConsoleColor.Blue)
    {
        Console.SetCursorPosition(x, y);
        Console.ForegroundColor = dcolor;
        Console.Write(str);
    }

    static void Main()
    {
        int playfieldWidth = 25;
        int livesCount = 5;
        int scoresCount = 0;
        Console.BufferHeight = Console.WindowHeight = 30;
        Console.BufferWidth = Console.WindowWidth = 55;
        Dwarf dwarf = new Dwarf();
        dwarf.myX = 12;
        dwarf.myY = Console.WindowHeight - 1;
        dwarf.str = "(0)";
        Random randomGenerator = new Random();
        List<Rock> rocks = new List<Rock>();

        while (true)
        {
            {
                char[] symbol = { '^', '@', '*', '&', '+', '%', '$', '#', '!', '.', ';', '-' };
                Random randomChar = new Random();
                int c = randomChar.Next(0, 12);
                char symbolPrint = symbol[c];

                string[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
                Random randomColor = new Random();
                string randomColorName = colorNames[randomColor.Next(colorNames.Length)];
                Rock newRock = new Rock();
                newRock.color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), randomColorName);
                if (newRock.color == ConsoleColor.Black) newRock.color = ConsoleColor.White;
                newRock.x = randomGenerator.Next(0, playfieldWidth);
                newRock.y = 0;
                newRock.c = symbolPrint;
                rocks.Add(newRock);
            }

            // Move rocks
            List<Rock> newList = new List<Rock>();
            for (int i = 0; i < rocks.Count; i++)
            {
                Rock oldRock = rocks[i];
                Rock newRock = new Rock();
                newRock.x = oldRock.x;
                newRock.y = oldRock.y + 1;
                newRock.c = oldRock.c;
                newRock.color = oldRock.color;
                if (newRock.x == dwarf.myX && newRock.y == dwarf.myY || newRock.x == dwarf.myX + 1
                    && newRock.y == dwarf.myY || newRock.x == dwarf.myX + 2 && newRock.y == dwarf.myY)
                {
                    livesCount--;
                    Console.Beep();
                    if (livesCount <= 0)
                    {
                        PrintStringPosition(8, 7, "GAME OVER!!!", ConsoleColor.Red);
                        Console.ReadLine();
                        return;
                    }
                }
                if (newRock.y < Console.WindowHeight)
                {
                    newList.Add(newRock);
                    scoresCount++;
                }

            }
            rocks = newList;
            // Move the dwarf
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                while (Console.KeyAvailable) Console.ReadKey(true);
                if (pressedKey.Key == ConsoleKey.LeftArrow)
                {
                    if (dwarf.myX - 1 >= 0)
                    {
                        dwarf.myX--;
                    }
                }
                else if (pressedKey.Key == ConsoleKey.RightArrow)
                {
                    if (dwarf.myX + 1 < playfieldWidth)
                    {
                        dwarf.myX++;
                    }
                }
            }
            Console.Clear();
            // Redraw playfield
            PrintDwarf(dwarf.myX, dwarf.myY, dwarf.str, dwarf.dcolor = ConsoleColor.Blue);
            foreach (Rock rock in rocks)
            {
                PrintPosition(rock.x, rock.y, rock.c, rock.color);
            }
            // Draw info
            for (int borderY = 0; borderY <= Console.WindowHeight - 1; borderY++)
            {
                PrintStringPosition(27, borderY, "||", ConsoleColor.White);
            }
            PrintStringPosition(30, 4, "Falling Bricks", ConsoleColor.Yellow);
            PrintStringPosition(30, 7, "Lives Left: " + livesCount, ConsoleColor.White);
            PrintStringPosition(30, 8, "Scores: " + scoresCount, ConsoleColor.White);
            PrintStringPosition(30, 11, "Controls:", ConsoleColor.DarkMagenta);
            PrintStringPosition(30, 12, "Use the left", ConsoleColor.Green);
            PrintStringPosition(30, 13, "and right arrow", ConsoleColor.Green);
            PrintStringPosition(30, 14, "to move the dwarf (0)", ConsoleColor.Green);
            //Slow down the program
            Thread.Sleep(150);
        }
    }
}