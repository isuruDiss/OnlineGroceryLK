using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryLK.Areas.Admin.Controllers;
using System.Threading.Tasks;

namespace UnitTestOnlineGroceryLK
{


    [TestClass]
   public class TestOrderController
    {

        [TestMethod]
        public async Task CheckOrders()
        {
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task ViewOrders()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);


        }
    }
}
