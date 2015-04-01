using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{
    public class Officer :ValueObject
    {
        public string Name { get; private set; }
        public DateSpan ActivityPeriod { get; private set; }
        public DateTime ChangeDate { get; private set; }

        public Officer(string name, DateTime start, DateTime end, DateTime changeDate)
        {
            if (String.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Nieprawidłowa nazwa prowadzącego!");
            Name = name;
            ActivityPeriod = new DateSpan(start,end);
            ChangeDate = changeDate;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
