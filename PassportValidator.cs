using System;
using System.Runtime.Serialization;

namespace org.tyaa.demo.dotnet.logging
{
  public class PassportValidator<T> where T: IEuPassport
  {
    public static bool Validate(T passport) {
      return passport.Name != "" && passport.Name.Length > 1
        && passport.SureName != "" && passport.SureName.Length > 1
        && passport.Sex.GetType().IsEnum;
    }
  }
}