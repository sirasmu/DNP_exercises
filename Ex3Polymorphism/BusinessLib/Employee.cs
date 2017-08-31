using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP
{
    public abstract class Employee
    {
      private string name;

      //public virtual double GetMonthSalary { get; } // er properties polymorphiske?

      public Employee(string name)
      {
         this.name = name;
      }

      public virtual double GetMonthSalary()
      {
         return 0.0;
      }
    }
}
