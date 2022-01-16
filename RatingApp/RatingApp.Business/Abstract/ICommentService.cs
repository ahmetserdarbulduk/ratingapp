using General.Core.Utilities.Results;
using RatingApp.Entities.Concrete;

namespace RatingApp.Business.Abstract{
    public interface ICommentService{
        IResult Add(Comment comment);
        IDataResult<List<Comment>> GetByProduct(int productId);
        IDataResult<double> GetAverage(int productId);
    }
}