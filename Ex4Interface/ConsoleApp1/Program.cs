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
         Company c = new Company(list);

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
         c.EmployNewEmployee( new PartTimeStudent( "Signe", 110, 45, 2016 ) );

         foreach(Employee item in list)
         {
            Console.WriteLine( item.Name );
            if( item.Name == "Signe" )
            {
               PartTimeStudent s = (PartTimeStudent) item;
               //check year by using break points
               s.Register( 2010 );
            }
         }

         Console.WriteLine( "Total sum {0}", c.GetMonthlySalaryTotal() );

         Console.ReadKey();

      }
   }
}
