using General.Core.Utilities.Results;
using RatingApp.Business.Abstract;
using RatingApp.Business.Constraints;
using RatingApp.DataAccess.Abstract;
using RatingApp.Entities.Concrete;
using RatingApp.Entities.Dtos;

namespace RatingApp.Business.Concrete{
    public class ProductManager : IProductService{
        IProductDal _productDal;
        public ProductManager(IProductDal productDal){ _productDal = productDal; }

        public IResult Add(Product product){
            _productDal.Add(product);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<List<Product>> GetAll(){
            return new SuccessDataResult<List<Product>>(_productDal.GetList(),Messages.SuccessMessage);
        }

        public IDataResult<Product> GetById(int id){
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id),Messages.SuccessMessage);
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails(){
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}