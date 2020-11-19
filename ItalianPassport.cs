using static org.tyaa.demo.dotnet.logging.IEuPassport;

namespace org.tyaa.demo.dotnet.logging
{
  public class ItalianPassport : IEuPassport
  {
    string name;
    string sureName;
    Gender sex;
    public string Name { get => name; set => name = value; }
    public string SureName { get => sureName; set => sureName = value; }
    public IEuPassport.Gender Sex { get => sex; set => sex = value; }
  }
}