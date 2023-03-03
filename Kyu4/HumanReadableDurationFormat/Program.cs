using BenchmarkDotNet.Running;
using HumanReadableDurationFormat;

BenchmarkDotNet.Reports.Summary summary = BenchmarkRunner.Run<Res>();

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Benchmark ended!. Press any key to close");
Console.ResetColor();
Console.ReadKey();

//using HumanReadableDurationFormat;

//Resolver r = new();
//r.Resolve();