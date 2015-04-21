using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{

    public class OfficerFluent
    {
        private readonly Officer _obj = new Officer();
        public OfficerFluent WithName(string name)
        {
            _obj.Name = name;
            return this;
        }

        public OfficerFluent WithRank(string rank)
        {
            _obj.Rank = rank;
            return this;
        }

    }



    public class Officer :ValueObject
    {
        public string Name { get; set; }
        public string Rank { get; set; }
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

        public Officer()
        {

        }

        

        public void WithRank(string rank)
        {

        }



        protected override IEnumerable<object> GetAtomicValues()
        {
            throw new NotImplementedException();
        }
    }
}
