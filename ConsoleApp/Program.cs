using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        private static readonly int SnakeStateTotal = 3;
        private const int SnakeState1 = 0;
        private const int SnakeState2 = 1;
        private const int SnakeState3 = 2;
        private static readonly int SnakeMoveCount = 50;
        private static readonly int SnakeRow = 5;
        private static readonly int SnakeSleepTime = 1000;
        static void Main(string[] args)
        {
            int x = SnakeState1;
            while (x < 50) {
                Console.Clear();
                Console.SetCursorPosition(x, SnakeMoveCount);

                switch(x% SnakeStateTotal)
                {
                    case SnakeState1 : Console.WriteLine("__@"); break;
                    case SnakeState2 : Console.WriteLine("_^@"); break;
                    case SnakeState3 : Console.WriteLine("^_@"); break;
                }
                Thread.Sleep(SnakeSleepTime);
                x++;
            }
        }
    }
}
