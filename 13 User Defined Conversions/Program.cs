using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_User_Defined_Conversions
{
  class Program
  {
    static void Main(string[] args)
    {
      float t;
      t = 98.6F;
      Console.Write("{0} to Celsius=",t);
      Console.WriteLine((Celsius)t);

      t = 0.6F;
      Console.Write("{0} to Fahrenheit=", t);
      Console.WriteLine((Fahrenheit)t);

      Console.ReadKey();
    }
  }
}
