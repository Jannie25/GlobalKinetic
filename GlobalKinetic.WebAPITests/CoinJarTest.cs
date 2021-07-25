using GlobalKinetic.Library.Controllers;
using GlobalKinetic.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace GlobalKinetic.WebAPITests
{
    public class CoinJarTest
    {
        ICoinJarService _service;
        CoinJarController _controller;

        public CoinJarTest()
        {
            _service = new CoinJarServiceFake();
            _controller = new CoinJarController(_service);
        }

        [Fact]
        public void AddCoin_AddUSACoin_ReturnsOkResult()
        {
            var okResult = _controller.AddCoin(new Models.General.USACoin() { Amount = 100, Volume = 10 }) as OkObjectResult;

            Assert.IsType<OkObjectResult>(okResult);
        }

        [Fact]
        public void AddCoin_AddRSACoin_ReturnsBadRequestResult()
        {
            var badRequestResult = _controller.AddCoin(new Models.General.RSACoin() { Amount = 100, Volume = 10 }) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(badRequestResult);
        }

        [Fact]
        public void ExceedVolume_AddUSACoin_ReturnsBadRequestResult()
        {
            var badRequestResult = _controller.AddCoin(new Models.General.USACoin() { Amount = 500, Volume = 50 }) as BadRequestObjectResult;

            Assert.IsType<BadRequestObjectResult>(badRequestResult);
        }

        [Fact]
        public void GetTotalAmount_WhenCalled_Returns100()
        {
            var okResult = _controller.GetTotalAmount() as OkObjectResult;

            decimal result = Assert.IsType<decimal>(okResult.Value);

            Assert.Equal(100, result);
        }

        [Fact]
        public void Reset_WhenCalled_ReturnsOkResult()
        {
            var okResult = _controller.Reset() as OkObjectResult;

            Assert.IsType<OkObjectResult>(okResult);
        }
    }
}
