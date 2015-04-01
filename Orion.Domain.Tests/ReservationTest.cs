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
        public void można_zabezpieczyć_osobę_w_ramach_tej_samej_jednostki_w_różnym_celu()
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
        public void zabezpieczenie_rejestruje_się_dla_konkretnej_jednostki()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void zabezpieczenie_rejestruje_się_dla_konkretnego_prowadzącego()
        {
            //Given
            const string officerName = "";
            var start = new DateTime(2015, 1, 1);
            var end = new DateTime(2015, 1, 20);
            var created = new DateTime(2015, 1, 1);
            
            //When
            var reservation = new Reservation(officerName,start,end,created);

            //Then
            Assert.IsNull(reservation);

        }

    }
}
