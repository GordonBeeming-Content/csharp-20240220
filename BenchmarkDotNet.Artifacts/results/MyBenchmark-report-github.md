``` ini

BenchmarkDotNet=v0.13.1, OS=macOS 14.3.1 (23D60) [Darwin 23.3.0]
Apple M3 Max, 1 CPU, 14 logical and 14 physical cores
.NET SDK=8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT
  DefaultJob : .NET 8.0.1 (8.0.123.58001), Arm64 RyuJIT


```
|         Method |     Mean |    Error |   StdDev |  Gen 0 | Allocated |
|--------------- |---------:|---------:|---------:|-------:|----------:|
| InstanceMethod | 30.46 ns | 0.518 ns | 0.485 ns | 0.0095 |      80 B |
|     Reflection | 60.62 ns | 1.231 ns | 1.152 ns | 0.0162 |     136 B |
