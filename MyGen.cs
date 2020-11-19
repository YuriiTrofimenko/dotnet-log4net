using System;
using System.Runtime.Serialization;

namespace org.tyaa.demo.dotnet.logging
{
  public class MyGen<T> where T: IDeserializationCallback, new()
  {
    public T Calculate(dynamic a, dynamic b) {
      if(a is Decimal && b is Decimal) {
        return Decimal.Add(a, b);
      } else {
        throw new Exception("Illegal arguments type");
      }
    }
  }
}