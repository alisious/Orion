using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Orion.Domain.Tests
{
    [TestClass]
    public class DateSpanTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void nie_można_utworzyć_okresu_z_datą_rozpoczęcia_późniejszą_niż_data_zakończenia()
        {
            //Given
            var start = new DateTime(2015,1,20); 
            var end = new DateTime(2015,1,1);
            //When
            var dateSpan = new DateSpan(start, end);
            //Then
            Assert.IsNull(dateSpan);

        }

        [TestMethod]
        public void można_utworzyć_okresu_z_datą_rozpoczęcia_wcześniejszą_niż_data_zakończenia()
        {
            //Given
            var start = new DateTime(2015, 1, 1);
            var end = new DateTime(2015, 1, 20);
            //When
            var dateSpan = new DateSpan(start, end);
            //Then
            Assert.IsNotNull(dateSpan);

        }

        [TestMethod]
        public void porównanie_takich_samych_okresów_zwraca_TRUE()
        {
            //Given
            var start = new DateTime(2015, 1, 1);
            var end = new DateTime(2015, 1, 20);
            //When
            var dateSpan1 = new DateSpan(start, end);
            var dateSpan2 = new DateSpan(start, end);
            //Then
            Assert.IsTrue(dateSpan1 == dateSpan2);

        }

        [TestMethod]
        public void porównanie_różnych_okresów_zwraca_FALSE()
        {
            //Given
            var start = new DateTime(2015, 1, 1);
            var end1 = new DateTime(2015, 1, 20);
            var end2 = new DateTime(2015, 2, 20);

            //When
            var dateSpan1 = new DateSpan(start, end1);
            var dateSpan2 = new DateSpan(start, end2);
            //Then
            Assert.IsFalse(dateSpan1 == dateSpan2);

        }
    }
}
