using Microsoft.AspNetCore.Mvc;
using RatingApp.Business.Abstract;
using RatingApp.WebUI.Models;

namespace RatingApp.WebUI.Controllers{
    public class ProductController : Controller{
        IProductService _productService;
        public ProductController(IProductService productService){ _productService = productService; }

        public IActionResult Index(int productId=1){
            var products = _productService.GetAll();
            ProductListViewModel model = new ProductListViewModel(){
                Products = products.Data,
                Message=products.Message
            };
            return View(model);
        }
    }
}