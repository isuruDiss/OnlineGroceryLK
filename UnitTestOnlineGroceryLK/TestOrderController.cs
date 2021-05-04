using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryLK.Areas.Admin.Controllers;
using OnlineGroceryLK.Areas.Customer.Controllers;
using OnlineGroceryLK.Data;
using System.Threading.Tasks;

namespace UnitTestOnlineGroceryLK
{


    [TestClass]
   public class TestOrderController
    {
        OrderController controller = new OrderController(null, null);

        [TestMethod]
        public async Task GetOrdersDetails()
        {

            ViewResult result = await controller.GetOrderDetails(5) as ViewResult;
            // _emailSender
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task GetOrdersStatus()
        {   
            ViewResult result =  controller.GetOrderStatus(5) as ViewResult;
            // _emailSender
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task ViewOrderHistory()
        {           

            ViewResult result = await controller.OrderHistory() as ViewResult;
            // Assert
            Assert.IsNotNull(result);


        }
    }
}
