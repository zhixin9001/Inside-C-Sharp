using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace New_Egg
{
  class Program
  {
    static void Main(string[] args)
    {
      #region 7 堆栈
      //int[] arr = new int[0];
      #endregion
      #region 15 new 覆盖基类
      //SubClass sub = new SubClass();
      //BaseClass baseC = new BaseClass();
      //baseC.Value = 100;
      //Console.WriteLine("{0} , {1}",baseC.Value, sub.Value);

      //Employee ep = new Employee();
      //ep.CalculatePay();
      //SalariedEmployee sep = new SalariedEmployee();
      //sep.CalculatePay();
      //Employee sep1 = new SalariedEmployee();
      //sep.CalculatePay();

      //BaseClass[] baseArr= new BaseClass[2];
      //baseArr[0] = new SubClass() { Value = 1};
      //baseArr[1] = new BaseClass() { Value = 0 };

      //foreach(var item in baseArr)
      //{
      //  Console.WriteLine(item.Value);
      //}

      #endregion
      #region 17 Paramters
      //Parameters param = new Parameters();
      //param.TestParams(0);
      //param.TestParams(0, 1);
      //param.TestParams(0, 1, 2);
      #endregion
      #region 22 FileMove
      //Directory.CreateDirectory("C#.NET");
      //File.Move(@"D:\NEG.TXT", @"C#.NET\NEG.TXT");
      #endregion
      #region 29 HashTable Set
      //Hashtable hash = new Hashtable();
      //hash.Add(1, 13);
      //hash.Add(2, 23);
      //Dictionary<int, int> dic = new Dictionary<int, int>();

      //Console.WriteLine(hash[1]); 
      #endregion
      #region 20 Try Catch
      //try
      //{
      //  Console.WriteLine("try");
      //  throw new Exception();
      //}
      //catch (Exception)
      //{
      //  Console.WriteLine("catch");
      //  System.Environment.Exit(0);
      //  throw;
      //}
      //finally
      //{
      //  Console.WriteLine("finally");
      //}

      #endregion
      #region Hex Decimal
      float a = 5.1F;
      float b = 5;
      Console.WriteLine();
      Console.WriteLine(a - b);
      double da = 5.1D;
      double db = 5;
      Console.WriteLine(da - db);
      decimal dexA = 5.1M;
      decimal dexB = 5;
      Console.WriteLine(dexA - dexB);
      int i = 9;
      decimal dexC = i;
      i = (int)dexA;
      a = (float)dexA;

      float f = 345.87657f;
      Console.WriteLine(f);
      double d = 345.975423578631742d;
      Console.WriteLine(d);
      float fx = float.MaxValue;
      Console.WriteLine((double)(fx*fx));

      double dx = double.MaxValue;
      Console.WriteLine((double)(dx * dx)/dx);
      #endregion


      Console.ReadKey();
    }

  }
}
