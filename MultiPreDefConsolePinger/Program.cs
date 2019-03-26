using System;
using System.Threading;
using System.Net.NetworkInformation;

namespace MultiPreDefConsolePinger
{
    class Program
    {
        static void Main()
        {
            Console.Title = "Predefined Console Pinger";
            Console.WindowHeight = 18;
            Console.WindowWidth = 101;

            string userInputOne;
            string userInputTwo;
            string userInputThree;

            Console.Write("Please enter the first address you would like to ping: ");
            userInputOne = Console.ReadLine();
            Console.Write("Please enter the second address you would like to ping: ");
            userInputTwo = Console.ReadLine();
            Console.Write("Please enter the third address you would like to ping: ");
            userInputThree = Console.ReadLine();
            Console.Clear();

            while (true)
            {
                loopOne();
                using (var ping = new Ping())
                    try
                    {
                        var reply = ping.Send(userInputOne);
                        if (reply.Status == IPStatus.Success)
                        {
                            drawColourBox(ConsoleColor.Green);
                            Console.SetCursorPosition(2, 2);
                            Console.WriteLine("Status: " + reply.Status + " User Input: {0} ", userInputOne + " IP Address: " + reply.Address + " Time: " + reply.RoundtripTime.ToString() + "ms");
                        }
                        else
                        {
                            drawColourBox(ConsoleColor.Yellow);
                            Console.SetCursorPosition(2, 2);
                            Console.WriteLine("Status: Failed User Input: {0}", userInputOne);
                        }
                    }
                    catch
                    {
                        drawColourBox(ConsoleColor.Red);
                        Console.SetCursorPosition(2, 2);
                        Console.WriteLine("Status: ERROR User Input: {0} Check Input and try again.", userInputOne);
                    }
                Console.SetCursorPosition(0, 6);
                using (var ping = new Ping())
                    try
                    {
                        var reply = ping.Send(userInputTwo);
                        if (reply.Status == IPStatus.Success)
                        {
                            drawColourBox(ConsoleColor.Green);
                            Console.SetCursorPosition(2, 8);
                            Console.WriteLine("Status: " + reply.Status + " User Input: {0} ", userInputTwo + " IP Address: " + reply.Address + " Time: " + reply.RoundtripTime.ToString() + "ms");
                        }
                        else
                        {
                            drawColourBox(ConsoleColor.Yellow);
                            Console.SetCursorPosition(2, 8);
                            Console.WriteLine("Status: Failed User Input: {0}", userInputTwo);
                        }
                    }
                    catch
                    {
                        drawColourBox(ConsoleColor.Red);
                        Console.SetCursorPosition(2, 8);
                        Console.WriteLine("Status: ERROR User Input: {0} Check Input and try again.", userInputTwo);
                    }
                Console.SetCursorPosition(0, 12);
                using (var ping = new Ping())
                    try
                    {
                        var reply = ping.Send(userInputThree);
                        if (reply.Status == IPStatus.Success)
                        {
                            drawColourBox(ConsoleColor.Green);
                            Console.SetCursorPosition(2, 14);
                            Console.WriteLine("Status: " + reply.Status + " User Input: {0} ", userInputThree + " IP Address: " + reply.Address + " Time: " + reply.RoundtripTime.ToString() + "ms");
                        }
                        else
                        {
                            drawColourBox(ConsoleColor.Yellow);
                            Console.SetCursorPosition(2, 14);
                            Console.WriteLine("Status: Failed User Input: {0}", userInputThree);
                        }
                    }
                    catch
                    {
                        drawColourBox(ConsoleColor.Red);
                        Console.SetCursorPosition(2, 14);
                        Console.WriteLine("Status: ERROR User Input: {0} Check Input and try again.", userInputThree);
                    }
            }
        }
        static void DrawLine(int w, char ends, char mids)
        {
            Console.Write(ends);
            for (int i = 1; i < w - 1; ++i)
                Console.Write(mids);
            Console.WriteLine(ends);
        }
        static void DrawBox(int w, int h)
        {
            DrawLine(w, '#', '#');
            for (int i = 1; i < h - 1; ++i)
                DrawLine(w, '#', ' ');
            DrawLine(w, '#', '#');
        }
        static void loopOne()
        {
            Console.SetCursorPosition(0, 0);
            Console.CursorVisible = false;
            Thread.Sleep(1000);
        }
        static void drawColourBox(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            DrawBox(100, 5);
        }
    }
}
