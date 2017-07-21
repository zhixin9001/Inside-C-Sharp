using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
  public struct Fahrenheit
  {
    public float Temp { get; set; }
    public Fahrenheit(float temp)
    {
      this.Temp = temp;
    }

    public static implicit operator Fahrenheit(float temp)
    {
      Fahrenheit f = new Fahrenheit(temp);
      return f;
    }

    public static implicit operator float(Fahrenheit f)
    {
      return (((f.Temp * 9) / 5) + 32);
    }
  }
}
