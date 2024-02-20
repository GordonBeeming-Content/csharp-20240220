namespace OtherLib;

public class MyApp
{
  public IWindow GetApp() => new MagicWindow();
}

file class MagicWindow : IWindow
{
  public string Name => "file";
}

