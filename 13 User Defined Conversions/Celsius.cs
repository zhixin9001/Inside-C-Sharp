using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_User_Defined_Conversions
{
  class Celsius
  {
    public float Temp { get; set; }
    private Celsius(float temp)
    {
      this.Temp = temp;
    }

    public static implicit operator Celsius(float temp)
    {
      Celsius c = new Celsius(temp);
      return c;
    }

    public static implicit operator float(Celsius c)
    {
      return (((c.Temp - 32) / 9) * 5);
    }
  }
}
