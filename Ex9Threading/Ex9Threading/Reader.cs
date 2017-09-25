using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace DNP
{
   class Reader
   {
      string fileName;
      public string data;
      public Reader( string fn ) { fileName = fn; }

      public void Read()
      {
         FileStream s = new FileStream(fileName, FileMode.Open);
         StreamReader r = new StreamReader(s);
         data = r.ReadToEnd();
         r.Close();
         s.Close();
      }

      public static void Main()
      {
         Reader r1 = new Reader(@"C:\OneDrive\one\ICT\VIA\semesters\sem4\DNP1\summer-autumn\DNP_exercises\Ex9Threading\MyOtherFiles\identical1.txt");
         Reader r2 = new Reader(@"C:\OneDrive\one\ICT\VIA\semesters\sem4\DNP1\summer-autumn\DNP_exercises\Ex9Threading\MyOtherFiles\identical2.txt");

         //add if r1 and r2 are not null
         Thread t0 = new Thread(r1.Read);
         Thread t1 = new Thread(r2.Read);
         t0.Start();
         t1.Start();

         #region //collapse visual studio thing
         t0.Join(); //wait until job is finished... also takes a timespan
         t1.Join(); //main thread is waiting for join
         #endregion

         Console.WriteLine( r1.data );
         Console.WriteLine( r2.data );

         if(r1.data == r2.data)
         {
            Console.WriteLine("They are identical");
         }
         else
         {
            Console.WriteLine("Not identical");
         }
         System.Console.ReadKey();
      }

      //@ \\ / problem with escape characters
   }
}
