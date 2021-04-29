using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryLK.Areas.Admin.Controllers;
using System.Threading.Tasks;


namespace UnitTestOnlineGroceryLK
{

    [TestClass]
    public  class TestHomeController
    {
        [TestMethod]
        public async Task CheckProducts()
        {
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task CheckCartItems()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);


        }
    }
}
