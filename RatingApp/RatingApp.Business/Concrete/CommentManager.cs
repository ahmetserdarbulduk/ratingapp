using General.Core.Utilities.Results;
using RatingApp.Business.Abstract;
using RatingApp.Business.Constraints;
using RatingApp.DataAccess.Abstract;
using RatingApp.Entities.Concrete;

namespace RatingApp.Business.Concrete{
    public class CommentManager : ICommentService{
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal){ _commentDal = commentDal; }

        public IResult Add(Comment comment){
            _commentDal.Add(comment);
            return new SuccessResult(Messages.SuccessMessage);
        }

        public IDataResult<double> GetAverage(int productId){
            var commentsById=_commentDal.GetList(c=>c.ProductId==productId);
            var commentCount=commentsById.Count();
            if (commentCount > 0){
                var total = 0;
                foreach (var comment in commentsById) { total += comment.Rating; }
                var average = total / commentCount;
                return new SuccessDataResult<double>(average);
            }
            return new ErrorDataResult<double>(0,Messages.NullMessage);
        }

        public IDataResult<List<Comment>> GetByProduct(int productId){
            return new SuccessDataResult<List<Comment>>(_commentDal.GetList(c=>c.ProductId==productId),Messages.SuccessMessage);
        }
    }
}