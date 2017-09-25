using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNP
{
   public class Car : IComparable<Car>
   {
      public int EngineSize
      {
         get { return engineSize; }
         set
         {
            if( EngineSize < 1600 ) engineSize = 1600;
            else if( EngineSize > 5000 ) engineSize = 5000;
            else engineSize = value;
         }
      }
      private int engineSize;

      private double weightKg;
      private int topSpeed;

      public Car( int engineSize, double weightKg, int topSpeed )
      {
         EngineSize = engineSize;
         this.weightKg = weightKg;
         this.topSpeed = topSpeed;
      }

      public int CompareTo( Car other )
      {
         if( other.topSpeed > this.topSpeed )
         {
            return -1;
         }
         else if( other.topSpeed < this.topSpeed )
         {
            return 1;
         }
         return 0;

         throw new NotImplementedException();
      }

      public override string ToString()
      {
         return string.Format("Car: top speed = {0}, kg = {1}, engine size = {2}", topSpeed, weightKg, EngineSize);
      }
   }
}
