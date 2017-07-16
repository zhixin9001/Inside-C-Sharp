using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
  class Program
  {
    static void Main(string[] args)
    {
      Invoice i1 = new Invoice();
      for(int i=0;i<2;i++)
      {
        i1.DetailLines.Add(new InvoiceDetailLine(i + 1));
      }

      Invoice i2 = new Invoice();
      for (int i = 0; i < 2; i++)
      {
        i2.DetailLines.Add(new InvoiceDetailLine(i + 1));
      }

      Invoice summaryInvoice = i1 + i2;
      summaryInvoice.PrintInvoice();

      Console.ReadKey();
    }
  }
}
