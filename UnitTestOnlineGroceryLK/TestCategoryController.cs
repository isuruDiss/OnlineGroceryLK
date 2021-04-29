using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineGroceryLK.Areas.Admin.Controllers;
using System.Threading.Tasks;


namespace UnitTestOnlineGroceryLK
{

    [TestClass]
    public  class TestCategoryController
    {
        [TestMethod]
        public async Task CreateCategory()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task UpdateCategory()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DeleteCategory()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public async Task DetailsCategory()
        {
            // arrange
            CategoryController controller = new CategoryController();

            ViewResult result = controller.Create() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
