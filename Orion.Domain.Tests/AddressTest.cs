using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orion.Domain.Tests
{
    [TestClass]
    public class AddressTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nie_można_utworzyć_adresu_bez_nazwy_miejscowości()
        {
            //Given
            const string city = "";
            //When
            var newAddress = Address.NewAddress(city, "", "", "", "");
            //Then
            Assert.IsNull(newAddress);
        }

        [TestMethod]
        public void porównywanie_takich_samych_adresów_zwraca_True()
        {
            //Given
            const string city = "WARSZAWA";
            const string street = "OSTROROGA";
            const string streetNo = "35A";
            
            //When
            var address1 = Address.NewAddress(city, street, streetNo);
            var address2 = Address.NewAddress(city, street, streetNo);
            
            //Then
            Assert.IsTrue(address1==address2);
            Assert.IsFalse(address1 != address2);
        }

        [TestMethod]
        public void porównywanie_różnych_adresów_zwraca_False()
        {
            //Given
            const string city = "WARSZAWA";
            const string street1 = "OSTROROGA";
            const string streetNo1 = "35A";
            const string street2 = "NOWA";
            const string streetNo2 = "10";

            //When
            var address1 = Address.NewAddress(city, street1, streetNo1);
            var address2 = Address.NewAddress(city, street2, streetNo2);

            //Then
            Assert.IsFalse(address1 == address2);
            Assert.IsTrue(address1!=address2);
        }
    }
}
