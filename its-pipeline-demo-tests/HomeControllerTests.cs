using its_pipeline_demo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Xunit;

namespace its_pipeline_demo_tests
{
    public class HomeControllerTests
    {
        private readonly ILogger<HomeController> _logger;

        [Fact]
        public void IndexViewTest()
        {
            var homeController = new HomeController(_logger);
            var result = homeController.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void TestPrivacy()
        {
            var homeController = new HomeController(_logger);
            var result = homeController.Privacy();

            Assert.IsType<ViewResult>(result);
        }
    }
}
