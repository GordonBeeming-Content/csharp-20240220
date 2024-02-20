public class MyAppPublic : AppBluePrint
{
  public string AppPublic => BluePrintPublic;
  internal string AppInternal => BluePrintInternal;
  private string AppPrivate => "private";
  public string Example => BluePrintProtected;
}

public class AppBluePrint
{
  public string BluePrintPublic => "public";
  internal string BluePrintInternal => "internal";
  private protected string BluePrintProtectedInternal => 
        "private protected";
  private string BluePrintPrivate => "private";
  protected string BluePrintProtected => "protected";
}