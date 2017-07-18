using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _17_Unmanaged_Code
{
  class Program
  {
    #region Call DLL

    [DllImport("user32.dll")]
    static extern int MessageBoxA(int hWnd, string msg, string caption, uint type);

    [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
    static extern int MessageBoxB(int hWnd, string msg, string caption, uint type);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern int MessageBox(int hWnd, string msg, string caption, uint type);

    #endregion

    #region Callback
    [DllImport("user32.dll")]
    static extern int GetWindowText(int hWnd, StringBuilder text, int count);

    delegate bool CallbackDef(int hWnd, int lParam);

    [DllImport("user32.dll")]
    static extern int EnumWindows(CallbackDef callback, int lParam);

    static bool PrintWindow(int hWnd, int lParam)
    {
      StringBuilder text = new StringBuilder(255);
      GetWindowText(hWnd, text, 255);
      Console.WriteLine("Window caption: {0}", text);
      return true;
    }
    #endregion

    #region Marshal

    [DllImport("user32.dll", EntryPoint = "MessageBoxA")]
    static extern int MessageBoxMarshal(
      int hWnd,
      [MarshalAs(UnmanagedType.LPStr)]
      string msg,
      [MarshalAs(UnmanagedType.LPStr)]
      string caption,
      uint type);
    #endregion

    static void Main(string[] args)
    {
      #region Call DLL
      //MessageBoxA(0, "This is 啊啊called from a c# app", "Hello", 0);
      //MessageBoxB(0, "This is called from a c# app", "Hello", 0);
      //MessageBox(0, "This is called from a c# app", "Hello", 0);
      //Console.ReadKey();
      #endregion

      #region Callback
      //CallbackDef callBack = new CallbackDef(PrintWindow);
      //EnumWindows(callBack, 0);
      //Console.ReadKey();
      #endregion

      #region Marshal
      //MessageBoxMarshal(0, "This is called from a c# app", "Hello", 0);
      #endregion

      #region Pointer
      Unsafe1App.MainMain();
      Console.ReadKey();
      #endregion
    }
  }


}
