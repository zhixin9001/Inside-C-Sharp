using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_Unmanaged_Code
{
  class PInvoke1App
  {
    [DllImport("user32.dll")]
    static extern int MessageBoxA(int hWnd, string msg, string caption, int type);   
  }
}
