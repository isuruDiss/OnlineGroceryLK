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
            ProductController controller = new ProductController();

            ViewResult result = await controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);

        }

        [TestMethod]
        public async Task UpdateProduct()
        {
            // arrange
            ProductController controller = new ProductController();

            ViewResult result =await controller.Edit(5) as ViewResult;
            // Assert
            Assert.IsNotNull(result);


        }

        [TestMethod]
        public async Task DeleteProduct()
        {
            // arrange
            ProductController controller = new ProductController();

            ViewResult result =await controller.Delete(5) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DetailsProduct()
        {
            // arrange
            ProductController controller = new ProductController();

            ViewResult result =await controller.Details(6) as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
