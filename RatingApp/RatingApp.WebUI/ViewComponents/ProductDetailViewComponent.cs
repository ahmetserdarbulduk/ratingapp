using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using RatingApp.Business.Abstract;
using RatingApp.WebUI.Models;

namespace RatingApp.WebUI.ViewComponents{
    public class ProductDetailViewComponent:ViewComponent{
        ICommentService _commentService;
        public ProductDetailViewComponent(ICommentService commentService){ _commentService = commentService; }
        public ViewViewComponentResult Invoke(){
            var productId = Convert.ToInt32(HttpContext.Request.Query["productId"]);
            if (productId == 0 || productId==null) { productId = 1; }
            var commentList = _commentService.GetByProduct(productId);
            var averageValue = _commentService.GetAverage(productId);
            var model = new ProductDetailViewModel {
                CommentList = commentList.Data,
                ProductAverageValue=averageValue.Data,
                Message=commentList.Message
            };
            return View(model);
        }
    }
}