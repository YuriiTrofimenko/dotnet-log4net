namespace org.tyaa.demo.dotnet.logging
{
  public interface IEuPassport : IPassport {
    public enum Gender { Male, Female }
    Gender Sex {get; set;}
  }
}