Console.WriteLine("Access Modifiers");

public class MyAppPublic
{
}

internal class MyAppInternal
{
  private class MyAppPrivate
  {  
  }  
}

#region no accesser defaults to internal

class MyAppAlsoInternal
{
}
struct StructInternal
{
}
record RecordInternal
{
}
enum EnumInternal
{
}
interface InterfaceInternal
{
}

#endregion


public class MyAppPublic2
{ 
  private class MyAppClassScope
  {
  }
}

file class MyAppFileScope
{
}
