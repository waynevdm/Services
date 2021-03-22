using Microsoft.VisualStudio.TestTools.UnitTesting;
using TheRoom.Services.Data;

namespace TheRoom.Services.Tests.Unit
{
    [TestClass]
    public class DataTests
    {
        [TestMethod]
        public void GetAll()
        {
            var repo = new ServiceRepository();
            var services = repo.GetAll();
            Assert.IsTrue(services.Count > 0);
        }

        [TestMethod]
        public void Search()
        {
            var repo = new ServiceRepository();
            var services = repo.SearchDescription("site", 10, 1);
            Assert.IsTrue(services.Count > 0);
        }
    }
}
