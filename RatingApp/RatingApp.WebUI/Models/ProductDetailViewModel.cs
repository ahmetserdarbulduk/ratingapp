using General.Core.Utilities.Results;
using RatingApp.Entities.Concrete;

namespace RatingApp.WebUI.Models{
    public class ProductDetailViewModel {
        public List<Comment> CommentList {get;set;}
        public double ProductAverageValue { get; set; }
        public string Message { get; set; }
    }
}