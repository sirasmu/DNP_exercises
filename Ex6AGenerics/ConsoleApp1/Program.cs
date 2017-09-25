using System;
using System.Collections.Generic;
using DNP;

namespace ConsoleApp1
{
   class Program
   {
      private static int GreaterCount<T>( List<T> list, double min ) where T : IComparable
      {
         int count = 0;
         foreach( var item in list )
         {
            if( item.CompareTo(min) >= 0 )
            {
               count++;
            }
         }
         return count;
      }

      static void Main( string[] args )
      {
         List<Car> list = new List<Car>();
         list.Add( new Car(1600, 200.0, 160) );
         list.Add( new Car( 5000, 200.0, 250 ) );
         list.Add( new Car( 5000, 200.0, 240 ) );
         list.Add( new Car( 5000, 200.0, 230 ) );
         list.Add( new Car( 5000, 200.0, 220 ) );


         foreach( Car item in list )
         {
            Console.WriteLine(item);
         }

         list.Sort();
         Console.WriteLine("\n");

         foreach( var item in list )
         {
            Console.WriteLine( item );
         }

         List<double> temperatures = new List<double>();

         temperatures.Add( 10.0 );
         temperatures.Add( 11.0 );
         temperatures.Add( 12.0 );
         temperatures.Add( 15.0 );
         temperatures.Add( 20.0 );
         temperatures.Add( 23.0 );
         temperatures.Add( 24.0 );
         temperatures.Add( 25.0 );
         temperatures.Add( 26.0 );
         temperatures.Add( 27.0 );

         

         Console.WriteLine( GreaterCount( temperatures, 25.0 ) );

         Console.ReadKey();

      }
   }

   
}
