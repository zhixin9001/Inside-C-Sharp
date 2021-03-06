﻿using System;
using System.Diagnostics;
using System.Reflection;

namespace _18_Assembly
{
  public class Module1Server
  {
  }
  class Module1ClientApp
  {
    public static void Main()
    {
      Assembly DllAssembly = Assembly.GetAssembly(typeof(Module1Server));
      Console.WriteLine("Module1Server.dll Assembly Information");
      Console.WriteLine("\t"+DllAssembly);
      Process p = Process.GetCurrentProcess();
      string AssemblyName = p.ProcessName + ".exe";
      Assembly ThisAssembly = Assembly.LoadFrom(AssemblyName);
      Console.WriteLine("Module1ClientApp.dll Assembly Information");
      Console.WriteLine("\t" + ThisAssembly);
    }
  }
}
