using BenchmarkDotNet.Attributes;

public class MyBenchmark
{
  [Benchmark]
  public string InstanceMethod()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    var app = new MyAppBenchmark();
    return app.Welcome(name);
  }

  [Benchmark]
  public string Reflection()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    var app = new MyAppBenchmark();
    return typeof(MyAppBenchmark)
        .GetMethod("WelcomePrivate", BindingFlags.NonPublic | BindingFlags.Instance)
        .Invoke(app, [name]) as string;
  }
}

public sealed class MyAppBenchmark
{
  public string Welcome(string name)=> $"Welcome {name}";
  private string WelcomePrivate(string name)=> $"Welcome {name}";
}