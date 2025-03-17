using crm_demo2;

namespace crm_demo_test
{
    [TestClass]
    public sealed class DBTest
    {
        private RequestController _requestController;

        [TestInitialize]
        public void Setup()
        {
            _requestController = new RequestController();
        }

        [TestMethod]
        public void TestGetAllRequests()
        {
            var result = _requestController.GetAllRequests();

            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void TestGetAllDoneRequests()
        {
            var status = "готова к выдаче";

            var result = _requestController.GetRequestsByStatus(status);

            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result[0].Status == status);
        }

        [TestMethod]
        public void TestGetRequestById()
        {
            var requestId = 1;

            var result = _requestController.GetRequestsById(requestId);

            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result[0].Id == requestId);
        }

        [TestMethod]
        public void TestGetRequestByIdAndStatus()
        {
            var requestId = 6;
            var status = "готова к выдаче";

            var result = _requestController.GetRequestsByIdAndStatus(requestId, status);

            Assert.IsTrue(result.Count > 0);
            Assert.IsTrue(result[0].Id == requestId);
            Assert.IsTrue(result[0].Status == status);
        }
    }
}
