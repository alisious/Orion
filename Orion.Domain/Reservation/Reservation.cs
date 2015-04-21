using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{
    public class Reservation :AggregateRoot
    {
        public DateSpan ReservationPeriod { get; private set; }
        private readonly IList<Officer> _conductingOfficers = new List<Officer>();
        public string OrganizationalUnit { get; private set; }
        public DateTime CreationDate { get; private set; }
        private readonly IList<Prolongation> _prolongations = new List<Prolongation>(); 

        public Reservation(string organizationalUnit,string officerName,DateTime start, DateTime end,DateTime registrationDate)
        {
            
            if (String.IsNullOrWhiteSpace(organizationalUnit))
                throw new ArgumentException("Wymagane jest podanie jednostki prowadzącej!");
            OrganizationalUnit = organizationalUnit;
            ReservationPeriod = new DateSpan(start, end);
            ChangeConductingOfficer(officerName,start,end,registrationDate);
            CreationDate = registrationDate;
        }

        public IReadOnlyList<Officer> Officers { get { return new List<Officer>(_conductingOfficers); }} 


        public void Prolong(DateTime prolongationDate, DateTime newEnd)
        {
            _prolongations.Add(new Prolongation());
        }

        public void ChangeConductingOfficer(string officerName,DateTime start,DateTime end,DateTime changeDate)
        {
            var newOfficer = new Officer(officerName, start, end, changeDate);
            _conductingOfficers.Add(newOfficer);
        }

        public IReadOnlyList<Prolongation> GetProlongations()
        {
            return new ReadOnlyCollection<Prolongation>(_prolongations);
            ;
        }

        public IReadOnlyList<Officer> GetConductingOfficers()
        {
            return new ReadOnlyCollection<Officer>(_conductingOfficers);
        }

    }
}
