using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ProducvitityTools.NetworkUtilities.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var externalIp = ExternalIP.Get();
        }
    }
}
