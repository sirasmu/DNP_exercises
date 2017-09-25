using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DNP;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Soap;

namespace Test
{
   class Program
   {
      static void Main( string[] args )
      {
         //BinaryFormatter
         string file1 = @"C:\OneDrive\one\ICT\VIA\semesters\sem4\DNP1\summer-autumn\DNP_exercises\Ex10StreamSerialize\MyFiles\WritePerson.bin";
         Person p = new Person("Kim", "Foged", 22);

         IFormatter formatter = new BinaryFormatter();

         Stream stream1 = new FileStream(file1, FileMode.Create, FileAccess.Write, FileShare.None);
         formatter.Serialize( stream1, p );
         stream1.Close();

         Stream stream2 = new FileStream(file1, FileMode.Open, FileAccess.Read, FileShare.None);
         Person newP = (Person) formatter.Deserialize(stream2);
         stream2.Close();
         Console.WriteLine(newP.FirstName);
         //Soap
         string file2 = @"C:\OneDrive\one\ICT\VIA\semesters\sem4\DNP1\summer-autumn\DNP_exercises\Ex10StreamSerialize\MyFiles\SoapPerson.soap";
         Person jeb = new Person("Jeb", "Bangsholt", 33);

         IFormatter soapFormatter = new SoapFormatter();

         Stream stream3 = new FileStream(file2, FileMode.Create);
         soapFormatter.Serialize( stream3, jeb );
         stream3.Close();

         Stream stream4 = new FileStream(file2, FileMode.Open, FileAccess.Read, FileShare.None);
         Person newJeb = (Person) soapFormatter.Deserialize(stream4);
         stream4.Close();
         Console.WriteLine( newJeb.FirstName );



         Console.ReadKey();
                

      }
   }
}
