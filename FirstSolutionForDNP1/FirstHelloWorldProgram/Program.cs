using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalDataClassesDLL;

namespace FirstHelloWorldProgram
{
   class Program
   {
      static void Main( string[] args )
      {
         Console.WriteLine( "Hello World" );
         Ex1();
         Ex2();
         Ex3();
         Ex4();

         CLBirdiecs.MakeSomeNoise();
         Dog dog = new Dog();

         Console.ReadKey();
         Console.Beep();
      }

      static void Ex1()
      {
         for( int i = 100; i <= 202; i += 2 )
         {
            Console.WriteLine( i );
         }
      }

      static void Ex2()
      {
         for( int i = 202; i >= 100; i -= 2 )
         {
            Console.WriteLine( i );
         }
      }

      static void Ex3()
      {
         int i = 100;
         while(i <= 202)
         {
            switch( i )
            {
               case 100:
               case 130:
               case 140:
                  Console.Write( i );
                  Console.WriteLine( "Funny num" );
                  break;
               case 122:
                  Console.Write( i );
                  Console.WriteLine( "Lucky num" );
                  break;
               case 198:
                  break;
               default:
                  Console.WriteLine( i );
                  break;
            }
            i++;
         }

      }


      static void Ex4()
      {
         for( int i = 1; i <= 255; i++ )
         {
            Console.WriteLine( "My hex {0:X}", i);
         }
      }
   }
}
