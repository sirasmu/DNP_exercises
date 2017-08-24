using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathLib;

namespace LibraryTest
{
   class Program
   {
      static void Main( string[] args )
      {
         double a = Arithmetic.Sub( 5, 4 );
         double b = Arithmetic.Add( 5, 4 );
         double c = Arithmetic.Mul( 5.0, 4.0 );
         
         Console.WriteLine( a );
         Console.WriteLine( b );
         Console.WriteLine( c );
         try
         {
            double d = Arithmetic.Div( 5.0, 4.0 );
            double e = Arithmetic.Div( 0.0, 0.0 );
            Console.WriteLine( d );
            Console.WriteLine( e );
         }
         catch(Exception e)
         {
            Console.WriteLine("Error");
         }
         Console.ReadKey();



      }

   }
}
