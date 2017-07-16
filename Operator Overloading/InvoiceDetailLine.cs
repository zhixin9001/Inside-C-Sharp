using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
  public class InvoiceDetailLine
  {
    double lineTotal;

    public double LineTotal { get => lineTotal; }

    public InvoiceDetailLine(double lineTotal)
    {
      this.lineTotal = lineTotal;
    }
  }
}
