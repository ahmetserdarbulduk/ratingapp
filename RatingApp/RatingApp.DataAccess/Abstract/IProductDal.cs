using General.Core.DataAccess;
using RatingApp.Entities.Concrete;
using RatingApp.Entities.Dtos;

namespace RatingApp.DataAccess.Abstract{
    public interface IProductDal:IGenericRepository<Product>{
        List<ProductDetailDto> GetProductDetails();
    }
}