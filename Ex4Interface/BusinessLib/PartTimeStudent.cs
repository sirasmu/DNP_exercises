using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP
{
   public class PartTimeStudent : PartTimeEmployee, IStudent
   {
      private int year;

      public PartTimeStudent( string name, double hourlyWage, int hoursPerMonth ) : base( name, hourlyWage, hoursPerMonth )
      {

      }

      public PartTimeStudent( string name, double hourlyWage, int hoursPerMonth, int year ) : base( name, hourlyWage, hoursPerMonth )
      {
         this.year = year;
      }

      public void Register( int year )
      {
         this.year = year;
      }
   }
}
