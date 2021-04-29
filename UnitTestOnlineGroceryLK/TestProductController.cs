using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryLK.Areas.Admin.Controllers;
using System.Threading.Tasks;

namespace UnitTestOnlineGroceryLK
{

    [TestClass]
   public  class TestProductController
    {

        [TestMethod]
        public async Task CreateProduct()
        {
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task UpdateProduct()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);


        }

        [TestMethod]
        public async Task DeleteProduct()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DetailsProduct()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
