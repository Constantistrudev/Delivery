using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Delivery;


namespace DeliveryTests
{
    [TestClass]
    public class UnitTest1
    {
        List<Deliverer> DeliverersTest = new List<Deliverer>(Fileworker.Deliverers);

        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
