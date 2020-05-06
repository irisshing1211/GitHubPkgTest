using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var obj = new TestClass {Id = 1, Name = "Testing"};
            Console.WriteLine(LogParser.LogParser.ConvertToHistory(obj));
        }
    }

    public class TestClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
