namespace org.tyaa.demo.dotnet.logging
{
  public class UkrainianPassport : IPassport
  {
    string name;
    string sureName;
    public string Name { get => name; set => name = value; }
    public string SureName { get => sureName; set => sureName = value; }
  }
}