using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lessen
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();
            CountDeligate d1 = helper.GetCount;
            CountDeligate d2 = helper.GetCountSymbolA;

            string testString = "LAMP";

            Console.WriteLine("Общие колличество символов: {0}", TestDeligate(d1, testString));
            Console.WriteLine("Колличество символов A: {0}", TestDeligate(d2, testString));
            Console.ReadLine();


        }

        static int TestDeligate(CountDeligate metod, string testString)
        {
            return metod(testString);
        }
    }

    public delegate int CountDeligate(string message);
    public class StringHelper
    {
        public int GetCount(string inputString)
        {
            return inputString.Length;
        }
        public int GetCountSymbolA(string inputString)
        {
            return inputString.Count(c => c == 'A');
        }
        public int GetCountSymbol(string inputString, char symbol)
        {
            return inputString.Count(c => c == symbol);
        }
    }
    public delegate void ShowMessage(string message);
    public class Student
    {
        public void Move(int distance, ShowMessage method)
        {
            for (int i = 0; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Идеи перемещение... Пройдено километров {0}", i));
            }
        }
    }
}
