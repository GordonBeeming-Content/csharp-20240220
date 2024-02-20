
var app = new MyApp();
var message = app.GetApp().Name;
Console.WriteLine(message);
Console.WriteLine(app.GetApp().GetType());


public class MyApp
{
  public IWindow GetApp() => new MagicWindow();
}

public interface IWindow
{
  string Name { get; }
}

file class MagicWindow: IWindow
{
    public string Name => "file";
}
