using System;
using IronPython;
using IronPython.Hosting;

namespace DemoMinorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some words: ...");
            var words = Console.ReadLine();

            var py = Python.CreateEngine();

            py.Execute("print('This is from python code.')");

            Console.ReadLine();
            
        }
    }
}
