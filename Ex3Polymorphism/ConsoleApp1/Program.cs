using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNP;

namespace ConsoleApp1
{
   class Program
   {
      static void Main( string[] args )
      {
         List<Employee> list = new List<Employee>();
         Company c = new Company();

         c.EmployNewEmployee( new FullTimeEmployee( "a", 1000 ) );
         c.EmployNewEmployee( new FullTimeEmployee( "c", 2000 ) );
         c.EmployNewEmployee( new FullTimeEmployee( "d", 3000 ) );
         c.EmployNewEmployee( new FullTimeEmployee( "e", 4000 ) );
         c.EmployNewEmployee( new FullTimeEmployee( "f", 5000 ) );
         c.EmployNewEmployee( new PartTimeEmployee( "g", 100, 10 ) );
         c.EmployNewEmployee( new PartTimeEmployee( "h", 200, 10 ) );
         c.EmployNewEmployee( new PartTimeEmployee( "i", 300, 10 ) );
         c.EmployNewEmployee( new PartTimeEmployee( "j", 400, 10 ) );
         c.EmployNewEmployee( new PartTimeEmployee( "k", 500, 10 ) );
         c.EmployNewEmployee( new PartTimeEmployee( "l", 600, 10 ) );

         
         Console.WriteLine( c.GetMonthlySalary() );

         Console.ReadKey();

      }
   }
}
