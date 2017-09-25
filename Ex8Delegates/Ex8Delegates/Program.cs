using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DNP
{
   class Program
   {

      delegate void MyAction<T>( T arg );

      static void Print<T>( T arg)
      {
         Console.WriteLine(arg);
      }

      static
      void Perform<T>( MyAction<T> act, T[] arr )
      {
         foreach( T item in arr )
         {
            act( item );
         }
      }

      static void Main( string[] args )
      {
         MyAction<int> act = Print;

         act( 42 );

         int[] arr = {1,2,3,4,5,6,7,8,9,10};

         Perform( act, arr );

         Console.ReadKey();

      }
   }
}
