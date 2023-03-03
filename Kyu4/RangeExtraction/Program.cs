using BenchmarkDotNet.Running;
using RangeExtraction;

BenchmarkDotNet.Reports.Summary summary = BenchmarkRunner.Run<Res>();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Benchmark ended!. Press any key to close");
Console.ResetColor();
Console.ReadKey();

//Res res = new();

//res.Resolve();
//res.ResolveAael();