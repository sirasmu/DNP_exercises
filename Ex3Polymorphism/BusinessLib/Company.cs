using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP
{
   public class Company
   {
      private List<Employee> employees;

      public Company( List<Employee> employees )
      {
         this.employees = employees;
      }

      public Company()
      {
         employees = new List<Employee>();
      }

      public double GetMonthlySalary()
      {
         double total = 0;
         foreach(Employee e in employees )
         {
            total += e.GetMonthSalary();
         }
         return total;
      }

      public void EmployNewEmployee(Employee newEmployee)
      {
         employees.Add( newEmployee );
      }
   }
}
