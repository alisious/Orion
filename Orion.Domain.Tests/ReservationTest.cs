using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orion.Domain.Tests
{
    [TestClass]
    public class ReservationTest
    {
        [TestMethod]
        public void data_rozpoczęcia_zabezpieczenia_musi_być_wcześniejsza_niż_data_zakończenia()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void nie_można_zabezpieczyć_osoby_będącej_współpracownikiem()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void nowa_data_zakończenia_nie_może_być_wcześniejsza_niż_aktualna()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void zabezpieczenie_może_dotyczyć_różnych_celów_w_ramach_tej_samej_jednostki()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void nie_można_zabezpieczyć_osoby_bez_kart_EO_1_i_EO_2()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void nie_można_aktualizować_zabezpieczenia_osoby_bez_karty_EO_A()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nie_można_zarejestrować_zabezpieczenia_bez_podania_jednostki()
        {
            //Given
            const string officerName = "NAZWISKO";
            const string organizationalUnit = "";
            var start = new DateTime(2015, 1, 1);
            var end = new DateTime(2015, 1, 20);
            var created = new DateTime(2015, 1, 1);
            var officer = new OfficerFluent();
             
            officer
                .WithName("KORPUSIK")
                .WithRank("PPŁK");

            //When
            var reservation = new Reservation(organizationalUnit,officerName, start, end, created);

            //Then
            Assert.IsNull(reservation);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nie_można_zarejestrować_zabezpieczenia_bez_podania_oficera_prowadzącego()
        {
            //Given
            const string officerName = "";
            const string organizationalUnit = "JEDNOSTKA";
            var start = new DateTime(2015, 1, 1);
            var end = new DateTime(2015, 1, 20);
            var created = new DateTime(2015, 1, 1);
            
            //When
            var reservation = new Reservation(organizationalUnit,officerName,start,end,created);

            //Then
            Assert.IsNull(reservation);

        }

    }
}
