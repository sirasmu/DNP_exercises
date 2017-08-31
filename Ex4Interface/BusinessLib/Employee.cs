using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP
{
    public abstract class Employee
    {
      public string Name { get; }

      //public virtual double GetMonthSalary { get; } // er properties polymorphiske?

      public Employee()
      {

      }

      public Employee( string name )
      {
         Name = name;
      }

      //public virtual double GetMonthSalary()
      //{
      //   return 0.0;
      //}

      public abstract double GetMonthSalary();
    }
}
