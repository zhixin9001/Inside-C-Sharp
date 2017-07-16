using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
  public class Invoice
  {
    public ArrayList DetailLines;
    public Invoice()
    {
      DetailLines = new ArrayList();
    }

    public void PrintInvoice()
    {
      Console.WriteLine("\nLine Nbr\tTotal");
      int i = 1;
      foreach (InvoiceDetailLine item in DetailLines)
      {
        Console.WriteLine("{0}\t\t{1}", i++, item.LineTotal);
      }
    }

    public static Invoice operator+(Invoice invoice1,Invoice invoice2)
    {
      Invoice returnInvoice = new Invoice();
      foreach(InvoiceDetailLine item in invoice1.DetailLines)
      {
        returnInvoice.DetailLines.Add(item);
      }
      foreach (InvoiceDetailLine item in invoice2.DetailLines)
      {
        returnInvoice.DetailLines.Add(item);
      }
      return returnInvoice;
    }
  }
}
