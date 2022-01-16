using General.Core.Utilities.Results;
using RatingApp.Entities.Concrete;
using RatingApp.Entities.Dtos;

namespace RatingApp.Business.Abstract{
    public interface IProductService{
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);
        IResult Add(Product product);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
    }
}