using RatingApp.Entities.Concrete;

namespace RatingApp.WebUI.Models{
    public class ProductListViewModel{
        public List<Product> Products { get; set; }
        public string Message { get; set; }
    }
}
