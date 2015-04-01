using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orion.Domain
{

  #pragma warning disable 661,660 //Equals and GetHashCode are overridden in ValueObject class.
    public class Address : ValueObject
  #pragma warning restore 661,660
    {
        public string City { get; private set; }
        public string Street { get; private set; }
        public string StreetNo { get; private set; }
        public string LocaleNo { get; private set; }
        public string PostalCode { get; private set; }

        private Address(string city, string street, string streetNo, string localeNo, string postalCode)
        {
            
            City = city;
            Street = street;
            StreetNo = streetNo;
            LocaleNo = localeNo;
            PostalCode = postalCode;
        }

        public static Address NewAddress(string city, string street, string streetNo, string localeNo="", string postalCode = "")
        {
            if (String.IsNullOrWhiteSpace(city)) 
                throw new ArgumentException(@"Nazwa miejscowości jest wymagana!");
            
            return new Address(city, street, streetNo, localeNo, postalCode);
        }


        #region Infrastructure

        protected Address()
        {

        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return City;
            yield return Street;
            yield return StreetNo;
            yield return LocaleNo;
            yield return PostalCode;

        }

        public static bool operator ==(Address left, Address right)
        {
            return EqualOperator(left, right);
        }

        public static bool operator !=(Address left, Address right)
        {
            return NotEqualOperator(left, right);
        }

        #endregion
    }
}
