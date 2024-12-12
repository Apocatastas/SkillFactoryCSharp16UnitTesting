using System;
using NUnit;
using NUnit.Framework.Legacy;

namespace UserTicketService.Tests
{
    [TestFixture]
    public class TicketServiceTests
    {
        [Test]
        public void GetTicketPriceMustReturnExistingPrice()
        {
            var ticketServiceTest = new TicketService();
            ClassicAssert.IsNotNull(ticketServiceTest.GetTicketPrice(1));
        }

        [Test]
        public void GetTicketPriceMustThrowException()
        {
            var ticketServiceTest = new TicketService();
            Assert.Throws<TicketNotFoundException>(() => ticketServiceTest.GetTicketPrice(100));
        }

        [Test]
        public void GetTicketMustReturnNotNullableTicket()
        {
            var ticketServiceTest = new TicketService();
            ClassicAssert.IsNotNull(ticketServiceTest.GetTicket(1));
        }

    }
}

