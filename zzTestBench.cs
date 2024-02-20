using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class MyBenchmark
{
  private readonly MethodInfo _welcomePrivate = typeof(MyApp).GetMethod("WelcomePrivate", BindingFlags.NonPublic | BindingFlags.Instance);

  [GlobalSetup]
  public void GlobalSetup()
  {
    //_welcomePrivate = typeof(MyApp).GetMethod("WelcomePrivate", BindingFlags.NonPublic | BindingFlags.Instance);
  }
  [Benchmark]
  public string InstanceMethodSealed()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    var app = new MySealedApp();
    return app.Welcome(name);
  }

  [Benchmark]
  public string InstanceMethod()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    var app = new MyApp();
    return app.Welcome(name);
  }


  [Benchmark]
  public string StaticMethod()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    return MyApp.WelcomeStatic(name);
  }

  [Benchmark]
  public string StaticMethodOnStaticClass()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    return MyStaticApp.WelcomeStatic(name);
  }

  [Benchmark]
  public string Reflection_Cold()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    var app = new MyApp();
    return typeof(MyApp).GetMethod("WelcomePrivate", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(app, [name]) as string;
  }

  [Benchmark]
  public string Reflection_Warm()
  {
    var name = DateTime.UtcNow.DayOfWeek.ToString();
    var app = new MyApp();
    return _welcomePrivate.Invoke(app, [name]) as string;
  }
}

public class MyApp
{
  public string Welcome(string name)=> $"Welcome {name}";
  private string WelcomePrivate(string name)=> $"Welcome {name}... don't tell anyone";
  public static string WelcomeStatic(string name)=> $"Welcome {name}... this shouldn't be here";
}

public static class MyStaticApp
{
  public static string WelcomeStatic(string name)=> $"Welcome {name}... this shouldn't be here";
}

public sealed class MySealedApp
{
  public string Welcome(string name)=> $"Welcome {name}... I hope this is faster";
}