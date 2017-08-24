using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLib
{
   public static class Arithmetic
   {
      public static int Add( int a, int b )
      {
         return a + b;
      }
      public static int Sub( int a, int b )
      {
         return a - b;
      }

      public static double Add( double a, double b )
      {
         return a + b;
      }
      public static double Sub( double a, double b )
      {
         return a - b;
      }

      public static int Mul( int a, int b )
      {
         return a * b;
      }

      public static int Div( int a, int b )
      {
         if( b == 0 )
         {
            throw new DivideByZeroException("Cannot divide by 0");
         }
         return a / b;
      }

      public static double Mul( double a, double b )
      {
         return a * b;
      }

      public static double Div( double a, double b )
      {
         if( b == 0 )
         {
            throw new DivideByZeroException( "Cannot divide by 0" );
         }
         return a / b;
      }
   }
}
