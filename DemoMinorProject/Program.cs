using System;
using System.Collections;
using System.Collections.Generic;
using IronPython;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace DemoMinorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputFile = "sample-orders.csv";
            var outputFile = "rfm-table.csv";
            var inputDate = "2019-11-23";
            ScriptEngine engine = Python.CreateEngine();
            dynamic scope = engine.CreateScope();
            ICollection<string> paths = engine.GetSearchPaths();
            string dir = @"C:\Python27amd64\Lib\site-packages";
            paths.Add(dir);
            engine.SetSearchPaths(paths);

            engine.ExecuteFile("rfm_analysis.py",scope);
            var result = scope.rfm(inputFile, outputFile, inputDate);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
