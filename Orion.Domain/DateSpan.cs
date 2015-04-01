using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{
    #pragma warning disable 661,660 //Equals and GetHashCode are overridden in ValueObject class.
    public class DateSpan : ValueObject
    #pragma warning restore 661,660
    {
       
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }
        
        public DateSpan(DateTime start, DateTime end) 
        {

            if (end < start)
                throw new ArgumentException(String.Format("{0} (od) jest późniejsza niż {1} (do)",start,end));
            Start = start;
            End = end;
        }
        
        #region Infrastructure

        
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Start;
            yield return End;
        }

        public static bool operator ==(DateSpan left, DateSpan right)
        {
            return EqualOperator(left, right);
        }

        public static bool operator !=(DateSpan left, DateSpan right)
        {
            return NotEqualOperator(left, right);
        }

        public override string ToString()
        {
            return String.Format("od: {0} do: {1}", Start, End);
        }

        #endregion
    }
}
