using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Egg
{
  class Parameters
  {
    public void TestParams(params int[] value)
    {
      Console.WriteLine("Using a params parameters!");
    }
    public void TestParams(int x, int y)
    {
      Console.WriteLine("Using two int parameters!");
    }
  }
}
