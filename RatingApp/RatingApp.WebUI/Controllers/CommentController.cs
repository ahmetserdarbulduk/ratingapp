using General.Core.Utilities.Results;
using Microsoft.AspNetCore.Mvc;
using RatingApp.Business.Abstract;
using RatingApp.Entities.Concrete;

namespace RatingApp.WebUI.Controllers{
    public class CommentController : Controller{
        ICommentService _commentService;
        public CommentController(ICommentService commentService){ _commentService = commentService; }

        [HttpGet]
        public IActionResult Add(){
            return View();
        }

        [HttpPost]
        public IActionResult Add(Comment comment){
            _commentService.Add(comment);
            return Redirect("~/Product/Index");
        }
    }
}
