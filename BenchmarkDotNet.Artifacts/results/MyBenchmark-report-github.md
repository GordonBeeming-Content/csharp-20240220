``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 14.3.1 (23D60) [Darwin 23.3.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT
  DefaultJob : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev |
|--------------- |---------:|---------:|---------:|
| InstanceMethod | 29.80 ns | 0.219 ns | 0.204 ns |
|     Reflection | 61.93 ns | 0.623 ns | 0.552 ns |
