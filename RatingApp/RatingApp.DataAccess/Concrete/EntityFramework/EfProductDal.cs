using General.Core.DataAccess.EntityFramework;
using RatingApp.DataAccess.Abstract;
using RatingApp.Entities.Concrete;
using RatingApp.Entities.Dtos;

namespace RatingApp.DataAccess.Concrete.EntityFramework{
    public class EfProductDal : EfGenericRepository<Product, RatingAppContext>, IProductDal{
        public List<ProductDetailDto> GetProductDetails(){
            using(RatingAppContext context=new RatingAppContext()) {
                var result = from p in context.Products
                             join c in context.Comments
                             on p.Id equals c.ProductId
                             select new ProductDetailDto{
                                 Id = p.Id,
                                 Name = p.Name,
                                 Description = p.Description,
                                 Rating = c.Rating };
                return result.ToList();
            }
        }
    }
}