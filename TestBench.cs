using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MyBenchmark
{
  [Benchmark]
  public int Test1()
  {
    return int.MaxValue;
  }

  [Benchmark]
  public int Test2()
  {
      return int.MaxValue;
  }

  [Benchmark]
  public int Test3()
  {
      return int.MaxValue;
  }
}
