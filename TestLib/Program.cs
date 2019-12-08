using System;
using Take.Blip.Client.Console;

namespace TestLib
{
    class Program
    {
        static int Main(string[] args) => ConsoleRunner.RunAsync(args).GetAwaiter().GetResult();
    }
}