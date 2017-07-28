using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Unmanaged_Code
{
  class Foo : IDisposable
  {
    public int x;

    public void Dispose()
    {
      Console.WriteLine("Disposing...");
    }
  }

  class Fixed1App
  {
    unsafe static void SetFooValue(int* x)
    {
      Console.WriteLine("Dereferenced pointer to modify foo.x");
      *x = 42;
    }

    public unsafe static void CallFixed()
    {
      Console.WriteLine("Creating the Foo Class");
      Foo foo = new Foo();
      Console.WriteLine("foo.x intialized to {0}", foo.x);
      Console.WriteLine("Setting pointer to foo.x");

      fixed (int* f = &foo.x)
      {
        Console.WriteLine("Calling SetFooValue, passing pointer to foo.x");
        SetFooValue(f);
        
      }
      Console.WriteLine("After return from SetFooValue, foo.x={0}", foo.x);
      foo = null;
      
    }
  }
}
