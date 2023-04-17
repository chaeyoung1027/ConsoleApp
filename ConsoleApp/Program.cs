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
        static void Main(string[] args)
        {
            Console.Write("메서드 호출1");   //절대값 기준
            Thread.Sleep(1000); //1000 = 1초
            Console.SetCursorPosition(5, 5);
            Console.Write("메서드 호출2");
            Thread.Sleep(2000);
            Console.SetCursorPosition(2, 2);
            Console.Write("메서드 호출3");
        }
    }
}
