
var app = new MyAppPublic();
var message = app.AppPublic;
Console.WriteLine(message);


public class MyAppPublic : AppBluePrint
{
  public string AppPublic => "public";
  internal string AppInternal => "internal";
  private string AppPrivate => "private";
  public string Example => BluePrintProtected;
}

public class AppBluePrint
{
  public string BluePrintPublic => "public";
  internal string BluePrintInternal => "internal";
  private string BluePrintPrivate => "private";
  protected internal string BluePrintProtected => "protected";
}

public class MyAppPublicHere : AppBluePrint
{
  public string AppPublic => "public";
  internal string AppInternal => "internal";
  private string AppPrivate => "private";
  public string Example => BluePrintProtected;
}
