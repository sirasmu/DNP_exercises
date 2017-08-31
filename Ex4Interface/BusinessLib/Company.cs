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

      public double GetMonthlySalaryTotal()
      {
         double sum = 0;
         foreach(Employee item in employees )
         {
            sum += item.GetMonthSalary();
         }
         return sum;
      }

      public void EmployNewEmployee(Employee newEmployee)
      {
         employees.Add( newEmployee );
      }
   }
}
