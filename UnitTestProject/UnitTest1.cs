using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tickets.Models;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void FirstName_Correct()
        {
            TicketModel a_person = new TicketModel { FirstName = "Dylan", LastName = "Grimes" };
            string expected = "Dylan";
            string actual = a_person.FirstName;
            Assert.AreEqual(expected, actual, "First name is correct");

        }

        [TestMethod]
        public void APrice_Correct()
        {

            TicketModel a_ticket = new TicketModel { TicketName = "Adult", Price = 10 };
            double expected1 = 10;
            double actual1 = a_ticket.Price;
            Assert.AreEqual(expected1, actual1, "Adult price is correct");
        }

        [TestMethod]
        public void MPrice_Correct()
        {

            TicketModel a_ticket = new TicketModel { TicketName = "Member", Price = 7 };
            double expected1 = 7;
            double actual1 = a_ticket.Price;
            Assert.AreEqual(expected1, actual1, "Member price is correct");
        }

        [TestMethod]
        public void CPrice_Correct()
        {

            TicketModel a_ticket = new TicketModel { TicketName = "Child", Price = 5 };
            double expected2 = 5;
            double actual2 = a_ticket.Price;
            Assert.AreEqual(expected2, actual2, "Child price is correct");
        }

        [TestMethod]
        public void PieandPint_Correct()
        {

            TicketModel a_ticket = new TicketModel { TicketName = "Pie and a Pint", Price = 5 };
            double expected3 = 5;
            double actual3 = a_ticket.Price;
            Assert.AreEqual(expected3, actual3, "Pie and Pint price is correct");
        }
    }
}
