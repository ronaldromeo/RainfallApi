using RainfallApi;
using RainfallApi.Controllers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RainfallApiTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void HappyPathTest()
        {
            StationsController stationsController = new StationsController();
            IActionResult _actual =  stationsController.GetRainfall(3680);
            var _expected = new StatusCodeResult(200);
            Assert.AreEqual(200, _expected.StatusCode);
           
        }

        [Test]
        public void UnhappyPathWrongStationIdTest()
        {
            StationsController stationsController = new StationsController();
            IActionResult _actual = stationsController.GetRainfall(1);
            var _expected = new StatusCodeResult(204);
            Assert.AreEqual(204, _expected.StatusCode);
        }

        [Test]
        public void UnhappyPathNotationIdTest()
        {
            StationsController stationsController = new StationsController();
            IActionResult _actual = stationsController.GetRainfall(0);
            var _expected = new StatusCodeResult(400);
            Assert.AreEqual(400, _expected.StatusCode);
        }
    }
}