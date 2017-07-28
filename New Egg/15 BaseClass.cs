using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Egg
{
  class BaseClass
  {
    public virtual int Value { get; set; }
    public virtual object this[int i]
    {
      set { }
    }
  }

  class SubClass : BaseClass
  {
    public override int Value { get; set; }
    public override object this[int i]
    {
      set { }
    }
  }

  class Employee
  {
    public void CalculatePay()
    {
      Console.WriteLine("Employee.CalculatePay()");
    }
  }
  class SalariedEmployee : Employee
  {
    public new void CalculatePay()
    {
      Console.WriteLine("SalariedEmployee.CalculatePay()");
    }
  }

}
