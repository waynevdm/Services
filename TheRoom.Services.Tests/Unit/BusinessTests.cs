using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRoom.Services.Data;
using TheRoom.Services.Business;

namespace TheRoom.Services.Tests.Unit
{
    [TestClass]
    public class BusinessTests
    {
        [TestMethod]
        public void Search()
        {
            var logic = new ServiceLogic(new ServiceRepository());
            try
            {
                var services = logic.SearchDescription("", 10, 1);
                Assert.Fail("You should get an exception!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual(ex.Message, "The filter is empty!");
            }
        }
    }
}
