using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Unmanaged_Code
{
  class Unsafe1App
  {
    public static unsafe void GetValues(int* x, int* y)
    {
      *x = 6;
      *y = 42;
    }
    public static unsafe void MainMain()
    {
      int a = 1, b = 2;
      Console.WriteLine("Before : a={0},b={1}", a, b);
      GetValues(&a, &b);
      Console.WriteLine("After : a={0},b={1}", a, b);
    }
  }
}
