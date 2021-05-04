using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryLK.Areas.Admin.Controllers;
using OnlineGroceryLK.Controllers;
using OnlineGroceryLK.Data;
using System.Threading.Tasks;


namespace UnitTestOnlineGroceryLK
{

    [TestClass]
    public  class TestHomeController
    {
        HomeController controller = new HomeController(null);


        [TestMethod]
        public async Task CheckProducts()
        {
            //ApplicationDbContext db=new ApplicationDbContext();
           
            ViewResult result = await controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task CheckItemDetails()
        {
            // arrange
         

            ViewResult result = await controller.Details(5) as ViewResult;
            // Assert
            Assert.IsNotNull(result);


        }
    }
}
