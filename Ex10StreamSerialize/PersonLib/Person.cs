using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP
{
   [Serializable]
    public class Person
    {
      public string  FirstName { get; set; }
      public string LastName { get; set; }
      public int Ssn { get; set; }

      public Person(string fN, string lN, int ssn)
      {
         FirstName = fN;
         LastName = lN;
         Ssn = ssn;
      }
   }
}
