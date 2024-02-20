Console.WriteLine("Access Modifiers");

IApp app = new MyAppPublic();

public class MyAppPublic : IApp
{
  public string Name => "App Name";
  public string SomethingElse { get; set; }
}

public interface IApp
{
  string Name { get; }
}