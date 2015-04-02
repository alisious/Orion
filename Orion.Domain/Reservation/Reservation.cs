using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{
    public class Reservation :AggregateRoot
    {
        public DateSpan ReservationPeriod { get; private set; }
        private IList<Officer> _officers;
        public string OrganizationalUnit { get; private set; }
        public DateTime CreationDate { get; private set; }

        private IList<Prolongation> _prolongations; 

        public Reservation(string organizationalUnit,string officerName,DateTime start, DateTime end,DateTime registrationDate)
        {
            
            if (String.IsNullOrWhiteSpace(organizationalUnit))
                throw new ArgumentException("Wymagane jest podanie jednostki prowadzącej!");
            OrganizationalUnit = organizationalUnit;
            ReservationPeriod = new DateSpan(start, end);
            _officers = new List<Officer>();
            ChangeOfficer(officerName,start,end,registrationDate);

            _prolongations = new List<Prolongation>();
            CreationDate = registrationDate;
        }

        public IReadOnlyList<Officer> Officers { get { return new List<Officer>(_officers); }} 


        public void Prolong(DateTime prolongationDate, DateTime newEnd)
        {
            throw new NotImplementedException();
        }

        public void ChangeOfficer(string officerName,DateTime start,DateTime end,DateTime changeDate)
        {
            var newOfficer = new Officer(officerName, start, end, changeDate);
            _officers.Add(newOfficer);
        }

    }
}
