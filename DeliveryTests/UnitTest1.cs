using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Delivery;
using System.Collections;


namespace DeliveryTests
{
    [TestClass]
    public class UnitTest1
    {
        static Deliverer a = new Deliverer()
        {
            DelivererNumber = "1111",
            NumberOfSucsessOrders = 20,
            NumberOfCancledOrders = 1,
            AverageDistanceTraveled = 1200,
            AverageDeliveryTime = 12,
            AverageOrderPrice = 1300,
            WorkTime = 13,
            WorkDay = new DateTime(2022, 01, 22),
            HaveVehicle = 0

        };
        static Deliverer b = new Deliverer()
        {
            DelivererNumber = "2222",
            NumberOfSucsessOrders = 15,
            NumberOfCancledOrders = 2,
            AverageDistanceTraveled = 2000,
            AverageDeliveryTime = 15,
            AverageOrderPrice = 3500,
            WorkTime = 13,
            WorkDay = new DateTime(2022, 01, 22),
            HaveVehicle = 1
        };
        static Deliverer c = new Deliverer()
        {
            DelivererNumber = "1111",
            NumberOfSucsessOrders = 10,
            NumberOfCancledOrders = 2,
            AverageDistanceTraveled = 500,
            AverageDeliveryTime = 10,
            AverageOrderPrice = 1000,
            WorkTime = 8,
            WorkDay = new DateTime(2022, 01, 23),
            HaveVehicle = 1
        };
        static Deliverer d = new Deliverer()
        {
            DelivererNumber = "3333",
            NumberOfSucsessOrders = 10,
            NumberOfCancledOrders = 4,
            AverageDistanceTraveled = 700,
            AverageDeliveryTime = 10,
            AverageOrderPrice = 1600,
            WorkTime = 5,
            WorkDay = new DateTime(2022, 01, 22),
            HaveVehicle = 0
        };
        static Deliverer e = new Deliverer()
        {
            DelivererNumber = "4444",
            NumberOfSucsessOrders = 25,
            NumberOfCancledOrders = 0,
            AverageDistanceTraveled = 3000,
            AverageDeliveryTime = 30,
            AverageOrderPrice = 2000,
            WorkTime = 14,
            WorkDay = new DateTime(2022, 01, 23),
            HaveVehicle = 1
        };
        List<Deliverer> DelivererTest = new List<Deliverer>() { a, b, c, d, e };
        [TestMethod]
        public void CountDeliveresPerDayTest()
        {
           
            DateTime dta = new DateTime(2022, 01, 22); 
            int sum =DayInfo.CountDeliveresPerDay(DelivererTest,dta);
            int answer = 52;
            Assert.AreEqual(sum,answer);
        }
        [TestMethod]
        public void CountOfAllSucsessDeliveresTest()
        {
            int sum = DayInfo.CountOfAllSucsessDeliveres(DelivererTest);
            int answer = 80;
            Assert.AreEqual(sum, answer);
        }
        [TestMethod]
        public void CountOfAllCancledDeliveresTest()
        {
            int sum = DayInfo.CountOfAllCancledDeliveres(DelivererTest);
            int answer = 9;
            Assert.AreEqual(sum, answer);
        }
        [TestMethod]
        public void CountOfAllDelivererWorkTimeTest()
        {
            int sum = DayInfo.CountOfAllDelivererWorkTime(DelivererTest,"1111");
            int answer = 21;
            Assert.AreEqual(sum, answer);
        }
        [TestMethod]
        public void GetProfitTest()
        {
            double sum = DayInfo.GetProfit(DelivererTest);
            double answer = 26550;
            Assert.AreEqual(sum, answer);
        }
        [TestMethod]
        public void GetAllPrice()
        {
            int sum = DayInfo.GetAllPrice(DelivererTest);
            int answer = 171200;
            Assert.AreEqual(sum, answer);
        }
    }
}
