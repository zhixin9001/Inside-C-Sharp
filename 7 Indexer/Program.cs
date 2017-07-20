using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Indexer
{
  class Program
  {
    static void Main(string[] args)
    {
      #region MyRegion
      MyListBox lbx = new MyListBox();
      lbx[0] = "foo";
      lbx[1] = "far";
      lbx[2] = "bar";
      Console.WriteLine("{0} {1} {2}",lbx[0],lbx[1],lbx[2]);
      #endregion

      Console.ReadKey();
    }
  }
}
